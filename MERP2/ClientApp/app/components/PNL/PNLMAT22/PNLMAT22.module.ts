import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT22Component } from './PNLMAT22.component';
import { PNLMAT22EntryComponent } from './entry/PNLMAT22.entry.component';
import { PNLMAT22ConditionComponent } from './condition/PNLMAT22.condition.component';
import { PNLMAT22QueryComponent } from './query/PNLMAT22.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT22.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT22Component, PNLMAT22EntryComponent, PNLMAT22ConditionComponent, PNLMAT22QueryComponent]
})
export class PNLMAT22Module { }
