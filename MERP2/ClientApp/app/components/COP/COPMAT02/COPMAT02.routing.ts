import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT02Component } from './COPMAT02.component';

const routes: Routes = [
    { path: '', component: COPMAT02Component }
];

export const routing = RouterModule.forChild(routes);
