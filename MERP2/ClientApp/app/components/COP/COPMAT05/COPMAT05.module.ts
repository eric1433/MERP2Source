import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT05Component } from './COPMAT05.component';
import { COPMAT05EntryComponent } from './entry/COPMAT05.entry.component';
import { COPMAT05ConditionComponent } from './condition/COPMAT05.condition.component';
import { COPMAT05QueryComponent } from './query/COPMAT05.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './COPMAT05.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [COPMAT05Component, COPMAT05EntryComponent, COPMAT05ConditionComponent, COPMAT05QueryComponent]
})
export class COPMAT05Module { }
