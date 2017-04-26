import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT14Component } from './PNLMAT14.component';
import { PNLMAT14EntryComponent } from './entry/PNLMAT14.entry.component';
import { PNLMAT14ConditionComponent } from './condition/PNLMAT14.condition.component';
import { PNLMAT14QueryComponent } from './query/PNLMAT14.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT14.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT14Component, PNLMAT14EntryComponent, PNLMAT14ConditionComponent, PNLMAT14QueryComponent]
})
export class PNLMAT14Module { }
