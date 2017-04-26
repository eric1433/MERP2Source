import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT28Component } from './PNLMAT28.component';
import { PNLMAT28EntryComponent } from './entry/PNLMAT28.entry.component';
import { PNLMAT28ConditionComponent } from './condition/PNLMAT28.condition.component';
import { PNLMAT28QueryComponent } from './query/PNLMAT28.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT28.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT28Component, PNLMAT28EntryComponent, PNLMAT28ConditionComponent, PNLMAT28QueryComponent]
})
export class PNLMAT28Module { }
