import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT04Component } from './PNLMAT04.component';

const routes: Routes = [
    { path: '', component: PNLMAT04Component }
];

export const routing = RouterModule.forChild(routes);
