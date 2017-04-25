import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ACTMAT02Component } from './ACTMAT02.component';

const routes: Routes = [
    { path: '', component: ACTMAT02Component }
];

export const routing = RouterModule.forChild(routes);
