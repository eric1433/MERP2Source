import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT31Component } from './PNLMAT31.component';

const routes: Routes = [
    { path: '', component: PNLMAT31Component }
];

export const routing = RouterModule.forChild(routes);
