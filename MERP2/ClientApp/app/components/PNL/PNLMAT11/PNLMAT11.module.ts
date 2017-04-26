import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT11Component } from './PNLMAT11.component';
import { PNLMAT11EntryComponent } from './entry/PNLMAT11.entry.component';
import { PNLMAT11ConditionComponent } from './condition/PNLMAT11.condition.component';
import { PNLMAT11QueryComponent } from './query/PNLMAT11.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT11.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT11Component, PNLMAT11EntryComponent, PNLMAT11ConditionComponent, PNLMAT11QueryComponent]
})
export class PNLMAT11Module { }
