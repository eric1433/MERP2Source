import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT10Component } from './PNLMAT10.component';
import { PNLMAT10EntryComponent } from './entry/PNLMAT10.entry.component';
import { PNLMAT10ConditionComponent } from './condition/PNLMAT10.condition.component';
import { PNLMAT10QueryComponent } from './query/PNLMAT10.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT10.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT10Component, PNLMAT10EntryComponent, PNLMAT10ConditionComponent, PNLMAT10QueryComponent]
})
export class PNLMAT10Module { }
