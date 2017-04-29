import * as React from 'react';
import 'isomorphic-fetch';
import { Link } from 'react-router';
import uniqid from 'uniqid';

interface FetchQueueListState {
    queues: QueueListItemViewModel[];
    loading: boolean;
}
 
export class QueueList extends React.Component<any, FetchQueueListState> {
    constructor() {
        super();
        this.state = { queues: [], loading: true };

        fetch('/api/queues')
            .then(response => response.json() as Promise<QueueListItemViewModel[]>)
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

    private static renderQueuesTable(queues: QueueListItemViewModel[]) {
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
                <tr key={ uniqid() }>
                    <td>
                        <Link to={ `/queues/${queue.name}` }>{ queue.name }</Link>
                    </td>
                    <td>{ queue.state }</td>
                    <td>{ queue.virtualHost }</td>
                    <td>{ queue.readyMessagesQuantity }</td>
                    <td>{ queue.unackedMessagesQuantity }</td>
                    <td>{ queue.totalMessagesQuantity }</td>
                </tr>
            )}
            </tbody>
        </table>;
    }
}

interface QueueListItemViewModel {
    name: string;
    state: string;
    virtualHost: string;
    readyMessagesQuantity: number;
    totalMessagesQuantity: number;
    unackedMessagesQuantity: number;
}