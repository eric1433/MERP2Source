import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT27Component } from './PNLMAT27.component';
import { PNLMAT27EntryComponent } from './entry/PNLMAT27.entry.component';
import { PNLMAT27ConditionComponent } from './condition/PNLMAT27.condition.component';
import { PNLMAT27QueryComponent } from './query/PNLMAT27.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT27.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT27Component, PNLMAT27EntryComponent, PNLMAT27ConditionComponent, PNLMAT27QueryComponent]
})
export class PNLMAT27Module { }
