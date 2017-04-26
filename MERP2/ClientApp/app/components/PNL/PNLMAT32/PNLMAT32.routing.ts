import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT32Component } from './PNLMAT32.component';

const routes: Routes = [
    { path: '', component: PNLMAT32Component }
];

export const routing = RouterModule.forChild(routes);
