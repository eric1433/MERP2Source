import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT26Component } from './PNLMAT26.component';

const routes: Routes = [
    { path: '', component: PNLMAT26Component }
];

export const routing = RouterModule.forChild(routes);
