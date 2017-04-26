import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT16Component } from './PNLMAT16.component';

const routes: Routes = [
    { path: '', component: PNLMAT16Component }
];

export const routing = RouterModule.forChild(routes);
