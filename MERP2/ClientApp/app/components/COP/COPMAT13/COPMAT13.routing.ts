import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT13Component } from './COPMAT13.component';

const routes: Routes = [
    { path: '', component: COPMAT13Component }
];

export const routing = RouterModule.forChild(routes);
