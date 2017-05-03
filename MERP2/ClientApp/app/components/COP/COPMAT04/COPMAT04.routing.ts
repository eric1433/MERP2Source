import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT04Component } from './COPMAT04.component';

const routes: Routes = [
    { path: '', component: COPMAT04Component }
];

export const routing = RouterModule.forChild(routes);
