import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT22Component } from './PNLMAT22.component';

const routes: Routes = [
    { path: '', component: PNLMAT22Component }
];

export const routing = RouterModule.forChild(routes);
