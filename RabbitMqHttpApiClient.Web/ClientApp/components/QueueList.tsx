import * as React from 'react';
import 'isomorphic-fetch';

interface FetchQueueListState {
    queues: Queue[];
    loading: boolean;
}
 
export class QueueList extends React.Component<any, FetchQueueListState> {
    constructor() {
        super();
        this.state = { queues: [], loading: true };

        fetch('/api/queues')
            .then(response => response.json() as Promise<Queue[]>)
            .then(data => {
                this.setState({ queues: data, loading: false });
            });
    }

    public render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : QueueList.renderQueuesTable(this.state.queues);

        return <div>
            <h1>RabbitMq Queues</h1>
            <p>This component demonstrates fetching data from the server.</p>
            { contents }
            <p>For more sophisticated applications, consider an architecture such as Redux or Flux for managing state. You can generate an ASP.NET Core application with React and Redux using <code>dotnet new aspnet/spa/reactredux</code> instead of using this template.</p>
        </div>;
    }

    private static renderQueuesTable(queues: Queue[]) {
        return <table className='table'>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>State</th>
                    <th>Virtual host</th>
                    <th>Ready</th>
                    <th>Unacked</th>
                    <th>Total</th>
                </tr>
            </thead>
            <tbody>
            {queues.map(queue =>
                <tr key={ queue.name }>
                    <td>{ queue.name }</td>
                    <td>{ queue.state }</td>
                    <td>{ queue.vhost }</td>
                    <td>{ queue.messages_ready }</td>
                    <td>{ queue.messages_unacknowledged }</td>
                    <td>{ queue.messages }</td>
                </tr>
            )}
            </tbody>
        </table>;
    }
}

interface Queue {
    name: string;
    state: string;
    vhost: string;
    messages: number;
    messages_ready: number;
    messages_unacknowledged: number;
}
