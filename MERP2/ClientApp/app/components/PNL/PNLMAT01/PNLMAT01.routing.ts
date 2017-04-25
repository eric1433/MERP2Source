import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT01Component } from './PNLMAT01.component';

const routes: Routes = [
    { path: '', component: PNLMAT01Component }
];

export const routing = RouterModule.forChild(routes);
