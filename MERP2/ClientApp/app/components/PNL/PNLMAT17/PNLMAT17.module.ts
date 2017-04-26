import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT17Component } from './PNLMAT17.component';
import { PNLMAT17EntryComponent } from './entry/PNLMAT17.entry.component';
import { PNLMAT17ConditionComponent } from './condition/PNLMAT17.condition.component';
import { PNLMAT17QueryComponent } from './query/PNLMAT17.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT17.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT17Component, PNLMAT17EntryComponent, PNLMAT17ConditionComponent, PNLMAT17QueryComponent]
})
export class PNLMAT17Module { }
