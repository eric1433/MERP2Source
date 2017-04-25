import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT05Component } from './PNLMAT05.component';
import { PNLMAT05EntryComponent } from './entry/PNLMAT05.entry.component';
import { PNLMAT05ConditionComponent } from './condition/PNLMAT05.condition.component';
import { PNLMAT05QueryComponent } from './query/PNLMAT05.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT05.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT05Component, PNLMAT05EntryComponent, PNLMAT05ConditionComponent, PNLMAT05QueryComponent]
})
export class PNLMAT05Module { }
