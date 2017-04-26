import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT08Component } from './PNLMAT08.component';
import { PNLMAT08EntryComponent } from './entry/PNLMAT08.entry.component';
import { PNLMAT08ConditionComponent } from './condition/PNLMAT08.condition.component';
import { PNLMAT08QueryComponent } from './query/PNLMAT08.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT08.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT08Component, PNLMAT08EntryComponent, PNLMAT08ConditionComponent, PNLMAT08QueryComponent]
})
export class PNLMAT08Module { }
