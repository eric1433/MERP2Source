import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT17Component } from './PNLMAT17.component';

const routes: Routes = [
    { path: '', component: PNLMAT17Component }
];

export const routing = RouterModule.forChild(routes);
