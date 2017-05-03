import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT06Component } from './COPMAT06.component';

const routes: Routes = [
    { path: '', component: COPMAT06Component }
];

export const routing = RouterModule.forChild(routes);
