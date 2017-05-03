import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT01Component } from './COPMAT01.component';
import { COPMAT01EntryComponent } from './entry/COPMAT01.entry.component';
import { COPMAT01ConditionComponent } from './condition/COPMAT01.condition.component';
import { COPMAT01QueryComponent } from './query/COPMAT01.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './COPMAT01.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [COPMAT01Component, COPMAT01EntryComponent, COPMAT01ConditionComponent, COPMAT01QueryComponent]
})
export class COPMAT01Module { }
