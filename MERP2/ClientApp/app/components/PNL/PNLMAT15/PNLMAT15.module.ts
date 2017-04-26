import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT15Component } from './PNLMAT15.component';
import { PNLMAT15EntryComponent } from './entry/PNLMAT15.entry.component';
import { PNLMAT15ConditionComponent } from './condition/PNLMAT15.condition.component';
import { PNLMAT15QueryComponent } from './query/PNLMAT15.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT15.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT15Component, PNLMAT15EntryComponent, PNLMAT15ConditionComponent, PNLMAT15QueryComponent]
})
export class PNLMAT15Module { }
