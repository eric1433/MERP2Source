import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT12Component } from './COPMAT12.component';
import { COPMAT12EntryComponent } from './entry/COPMAT12.entry.component';
import { COPMAT12ConditionComponent } from './condition/COPMAT12.condition.component';
import { COPMAT12QueryComponent } from './query/COPMAT12.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './COPMAT12.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [COPMAT12Component, COPMAT12EntryComponent, COPMAT12ConditionComponent, COPMAT12QueryComponent]
})
export class COPMAT12Module { }
