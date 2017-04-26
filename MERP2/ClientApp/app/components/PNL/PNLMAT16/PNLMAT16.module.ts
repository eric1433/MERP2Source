import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT16Component } from './PNLMAT16.component';
import { PNLMAT16EntryComponent } from './entry/PNLMAT16.entry.component';
import { PNLMAT16ConditionComponent } from './condition/PNLMAT16.condition.component';
import { PNLMAT16QueryComponent } from './query/PNLMAT16.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT16.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT16Component, PNLMAT16EntryComponent, PNLMAT16ConditionComponent, PNLMAT16QueryComponent]
})
export class PNLMAT16Module { }
