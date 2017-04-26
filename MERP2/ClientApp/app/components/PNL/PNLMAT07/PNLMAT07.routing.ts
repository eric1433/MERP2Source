import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT07Component } from './PNLMAT07.component';

const routes: Routes = [
    { path: '', component: PNLMAT07Component }
];

export const routing = RouterModule.forChild(routes);
