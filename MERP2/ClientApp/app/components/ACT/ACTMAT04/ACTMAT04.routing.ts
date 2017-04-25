import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ACTMAT04Component } from './ACTMAT04.component';

const routes: Routes = [
    { path: '', component: ACTMAT04Component }
];

export const routing = RouterModule.forChild(routes);
