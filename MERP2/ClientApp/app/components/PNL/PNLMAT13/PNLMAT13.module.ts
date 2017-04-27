import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT13Component } from './PNLMAT13.component';
import { PNLMAT13EntryComponent } from './entry/PNLMAT13.entry.component';
import { PNLMAT13ConditionComponent } from './condition/PNLMAT13.condition.component';
import { PNLMAT13QueryComponent } from './query/PNLMAT13.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT13.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT13Component, PNLMAT13EntryComponent, PNLMAT13ConditionComponent, PNLMAT13QueryComponent]
})
export class PNLMAT13Module { }
