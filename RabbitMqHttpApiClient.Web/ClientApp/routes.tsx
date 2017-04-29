import * as React from 'react';
import { Router, Route, HistoryBase } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { QueueList } from './components/QueueList';
import { Counter } from './components/Counter';
import { QueueCard } from './components/QueueCard';

export default <Route component={ Layout }>
    <Route path='/' components={{ body: Home }} />
    <Route path='/counter' components={{ body: Counter }} />
    <Route path='/queues' components={{ body: QueueList }} />
    <Route path="/queues/:name" components={{ body: QueueCard }} /> 
</Route>;

// Allow Hot Module Reloading
declare var module: any;
if (module.hot) {
    module.hot.accept();
}
