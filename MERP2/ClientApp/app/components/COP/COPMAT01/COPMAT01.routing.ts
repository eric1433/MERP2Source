import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT01Component } from './COPMAT01.component';

const routes: Routes = [
    { path: '', component: COPMAT01Component }
];

export const routing = RouterModule.forChild(routes);
