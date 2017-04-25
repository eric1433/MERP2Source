import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT02Component } from './PNLMAT02.component';
import { PNLMAT02EntryComponent } from './entry/PNLMAT02.entry.component';
import { PNLMAT02ConditionComponent } from './condition/PNLMAT02.condition.component';
import { PNLMAT02QueryComponent } from './query/PNLMAT02.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT02.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT02Component, PNLMAT02EntryComponent, PNLMAT02ConditionComponent, PNLMAT02QueryComponent]
})
export class PNLMAT02Module { }
