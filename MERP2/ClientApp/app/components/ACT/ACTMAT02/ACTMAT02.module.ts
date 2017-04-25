import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ACTMAT02Component } from './ACTMAT02.component';
import { ACTMAT02EntryComponent } from './entry/ACTMAT02.entry.component';
import { ACTMAT02ConditionComponent } from './condition/ACTMAT02.condition.component';
import { ACTMAT02QueryComponent } from './query/ACTMAT02.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './ACTMAT02.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [ACTMAT02Component, ACTMAT02EntryComponent, ACTMAT02ConditionComponent, ACTMAT02QueryComponent]
})
export class ACTMAT02Module { }
