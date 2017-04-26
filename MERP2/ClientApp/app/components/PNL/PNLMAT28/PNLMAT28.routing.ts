import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT28Component } from './PNLMAT28.component';

const routes: Routes = [
    { path: '', component: PNLMAT28Component }
];

export const routing = RouterModule.forChild(routes);
