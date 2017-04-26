import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT14Component } from './PNLMAT14.component';

const routes: Routes = [
    { path: '', component: PNLMAT14Component }
];

export const routing = RouterModule.forChild(routes);
