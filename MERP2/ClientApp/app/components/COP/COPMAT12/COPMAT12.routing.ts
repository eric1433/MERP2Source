import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT12Component } from './COPMAT12.component';

const routes: Routes = [
    { path: '', component: COPMAT12Component }
];

export const routing = RouterModule.forChild(routes);
