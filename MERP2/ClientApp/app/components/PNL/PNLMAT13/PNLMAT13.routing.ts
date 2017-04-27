import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT13Component } from './PNLMAT13.component';

const routes: Routes = [
    { path: '', component: PNLMAT13Component }
];

export const routing = RouterModule.forChild(routes);
