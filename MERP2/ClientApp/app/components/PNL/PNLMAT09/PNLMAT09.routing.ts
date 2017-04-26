import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT09Component } from './PNLMAT09.component';

const routes: Routes = [
    { path: '', component: PNLMAT09Component }
];

export const routing = RouterModule.forChild(routes);
