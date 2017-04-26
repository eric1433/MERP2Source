import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT18Component } from './PNLMAT18.component';

const routes: Routes = [
    { path: '', component: PNLMAT18Component }
];

export const routing = RouterModule.forChild(routes);
