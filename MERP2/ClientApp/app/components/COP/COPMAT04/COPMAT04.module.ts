import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT04Component } from './COPMAT04.component';
import { COPMAT04EntryComponent } from './entry/COPMAT04.entry.component';
import { COPMAT04ConditionComponent } from './condition/COPMAT04.condition.component';
import { COPMAT04QueryComponent } from './query/COPMAT04.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './COPMAT04.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [COPMAT04Component, COPMAT04EntryComponent, COPMAT04ConditionComponent, COPMAT04QueryComponent]
})
export class COPMAT04Module { }
