import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT05Component } from './PNLMAT05.component';

const routes: Routes = [
    { path: '', component: PNLMAT05Component }
];

export const routing = RouterModule.forChild(routes);
