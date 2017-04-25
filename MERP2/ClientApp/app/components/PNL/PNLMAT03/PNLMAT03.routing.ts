import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT03Component } from './PNLMAT03.component';

const routes: Routes = [
    { path: '', component: PNLMAT03Component }
];

export const routing = RouterModule.forChild(routes);
