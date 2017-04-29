import * as React from 'react';
import 'isomorphic-fetch';
import { Link } from 'react-router';
import uniqid from 'uniqid';
import JSON from 'json5';

interface FetchQueueDetailsState {
    queue: QueueCardViewModel;
    loading: boolean;
}
 
export class QueueCard extends React.Component<any, FetchQueueDetailsState> {
    constructor(props) {
        console.log("QueueCard constructor");
        super(props);
        this.state = { queue: null, loading: true };
        
        fetch(`/api/queues/${props.params.name}`)
            .then(response => response.json() as Promise<QueueCardViewModel>)
            .then(data => {
                this.setState({ queue: data, loading: false });
            });
    }
 
    public render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : QueueCard.renderQueueDetails(this.state.queue);

        return <div>
            <h2>Queue Details</h2>
            { contents }
        </div>;
    }

    private static renderQueueDetails(queue: QueueCardViewModel) {
        return <div>
            <h3> -- { queue.name } -- </h3>
            <table className='table table-bordered'>
                <thead>
                    <tr>
                        <th>Payload</th>
                    </tr>
                </thead>
                <tbody>
                {queue.messages.map(message =>
                    <tr key={ uniqid() }>
                        <td>{ message.payloadBytes } bytes 
                            <pre>{ JSON.stringify(JSON.parse(message.payload), null, 2) }</pre>
                        </td>
                    </tr>
                )}
                </tbody>
            </table>
        </div>;
    }
}

interface QueueCardViewModel {
    name: string;
    messages: QueueMessage[];
}

interface QueueMessage {
    payload: string;
    payloadBytes: number;
}