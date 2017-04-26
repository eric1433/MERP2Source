import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT11Component } from './PNLMAT11.component';

const routes: Routes = [
    { path: '', component: PNLMAT11Component }
];

export const routing = RouterModule.forChild(routes);
