import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ACTMAT01Component } from './ACTMAT01.component';

const routes: Routes = [
    { path: '', component: ACTMAT01Component }
];

export const routing = RouterModule.forChild(routes);
