import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT09Component } from './PNLMAT09.component';
import { PNLMAT09EntryComponent } from './entry/PNLMAT09.entry.component';
import { PNLMAT09ConditionComponent } from './condition/PNLMAT09.condition.component';
import { PNLMAT09QueryComponent } from './query/PNLMAT09.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT09.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT09Component, PNLMAT09EntryComponent, PNLMAT09ConditionComponent, PNLMAT09QueryComponent]
})
export class PNLMAT09Module { }
