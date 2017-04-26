import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT08Component } from './PNLMAT08.component';

const routes: Routes = [
    { path: '', component: PNLMAT08Component }
];

export const routing = RouterModule.forChild(routes);
