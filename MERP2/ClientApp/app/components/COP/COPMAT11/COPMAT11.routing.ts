import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT11Component } from './COPMAT11.component';

const routes: Routes = [
    { path: '', component: COPMAT11Component }
];

export const routing = RouterModule.forChild(routes);
