import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT06Component } from './PNLMAT06.component';

const routes: Routes = [
    { path: '', component: PNLMAT06Component }
];

export const routing = RouterModule.forChild(routes);
