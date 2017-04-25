import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT01Component } from './PNLMAT01.component';
import { PNLMAT01EntryComponent } from './entry/PNLMAT01.entry.component';
import { PNLMAT01ConditionComponent } from './condition/PNLMAT01.condition.component';
import { PNLMAT01QueryComponent } from './query/PNLMAT01.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT01.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT01Component, PNLMAT01EntryComponent, PNLMAT01ConditionComponent, PNLMAT01QueryComponent]
})
export class PNLMAT01Module { }
