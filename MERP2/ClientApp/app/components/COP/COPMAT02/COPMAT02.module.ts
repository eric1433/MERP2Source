import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT02Component } from './COPMAT02.component';
import { COPMAT02EntryComponent } from './entry/COPMAT02.entry.component';
import { COPMAT02ConditionComponent } from './condition/COPMAT02.condition.component';
import { COPMAT02QueryComponent } from './query/COPMAT02.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './COPMAT02.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [COPMAT02Component, COPMAT02EntryComponent, COPMAT02ConditionComponent, COPMAT02QueryComponent]
})
export class COPMAT02Module { }
