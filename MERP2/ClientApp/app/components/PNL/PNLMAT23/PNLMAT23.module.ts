import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT23Component } from './PNLMAT23.component';
import { PNLMAT23EntryComponent } from './entry/PNLMAT23.entry.component';
import { PNLMAT23ConditionComponent } from './condition/PNLMAT23.condition.component';
import { PNLMAT23QueryComponent } from './query/PNLMAT23.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT23.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT23Component, PNLMAT23EntryComponent, PNLMAT23ConditionComponent, PNLMAT23QueryComponent]
})
export class PNLMAT23Module { }
