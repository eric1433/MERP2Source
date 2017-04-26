import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT27Component } from './PNLMAT27.component';

const routes: Routes = [
    { path: '', component: PNLMAT27Component }
];

export const routing = RouterModule.forChild(routes);
