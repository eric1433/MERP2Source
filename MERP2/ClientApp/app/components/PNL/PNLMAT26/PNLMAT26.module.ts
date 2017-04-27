import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT26Component } from './PNLMAT26.component';
import { PNLMAT26EntryComponent } from './entry/PNLMAT26.entry.component';
import { PNLMAT26ConditionComponent } from './condition/PNLMAT26.condition.component';
import { PNLMAT26QueryComponent } from './query/PNLMAT26.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT26.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT26Component, PNLMAT26EntryComponent, PNLMAT26ConditionComponent, PNLMAT26QueryComponent]
})
export class PNLMAT26Module { }
