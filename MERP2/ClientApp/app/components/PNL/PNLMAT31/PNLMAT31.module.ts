import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT31Component } from './PNLMAT31.component';
import { PNLMAT31EntryComponent } from './entry/PNLMAT31.entry.component';
import { PNLMAT31ConditionComponent } from './condition/PNLMAT31.condition.component';
import { PNLMAT31QueryComponent } from './query/PNLMAT31.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT31.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT31Component, PNLMAT31EntryComponent, PNLMAT31ConditionComponent, PNLMAT31QueryComponent]
})
export class PNLMAT31Module { }
