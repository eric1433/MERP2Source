import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT23Component } from './PNLMAT23.component';

const routes: Routes = [
    { path: '', component: PNLMAT23Component }
];

export const routing = RouterModule.forChild(routes);
