import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT15Component } from './PNLMAT15.component';

const routes: Routes = [
    { path: '', component: PNLMAT15Component }
];

export const routing = RouterModule.forChild(routes);
