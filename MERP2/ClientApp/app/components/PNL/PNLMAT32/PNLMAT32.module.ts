import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT32Component } from './PNLMAT32.component';
import { PNLMAT32EntryComponent } from './entry/PNLMAT32.entry.component';
import { PNLMAT32ConditionComponent } from './condition/PNLMAT32.condition.component';
import { PNLMAT32QueryComponent } from './query/PNLMAT32.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT32.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT32Component, PNLMAT32EntryComponent, PNLMAT32ConditionComponent, PNLMAT32QueryComponent]
})
export class PNLMAT32Module { }
