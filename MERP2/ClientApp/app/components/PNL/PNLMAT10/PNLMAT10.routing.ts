import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT10Component } from './PNLMAT10.component';

const routes: Routes = [
    { path: '', component: PNLMAT10Component }
];

export const routing = RouterModule.forChild(routes);
