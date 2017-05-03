import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT07Component } from './COPMAT07.component';

const routes: Routes = [
    { path: '', component: COPMAT07Component }
];

export const routing = RouterModule.forChild(routes);
