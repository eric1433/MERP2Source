import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT02Component } from './PNLMAT02.component';

const routes: Routes = [
    { path: '', component: PNLMAT02Component }
];

export const routing = RouterModule.forChild(routes);
