import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT05Component } from './COPMAT05.component';

const routes: Routes = [
    { path: '', component: COPMAT05Component }
];

export const routing = RouterModule.forChild(routes);
