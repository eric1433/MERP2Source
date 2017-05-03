import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT03Component } from './COPMAT03.component';

const routes: Routes = [
    { path: '', component: COPMAT03Component }
];

export const routing = RouterModule.forChild(routes);
