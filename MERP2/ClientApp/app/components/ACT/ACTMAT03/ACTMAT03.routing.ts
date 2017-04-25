import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ACTMAT03Component } from './ACTMAT03.component';

const routes: Routes = [
    { path: '', component: ACTMAT03Component }
];

export const routing = RouterModule.forChild(routes);
