import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT18Component } from './PNLMAT18.component';
import { PNLMAT18EntryComponent } from './entry/PNLMAT18.entry.component';
import { PNLMAT18ConditionComponent } from './condition/PNLMAT18.condition.component';
import { PNLMAT18QueryComponent } from './query/PNLMAT18.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT18.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT18Component, PNLMAT18EntryComponent, PNLMAT18ConditionComponent, PNLMAT18QueryComponent]
})
export class PNLMAT18Module { }
