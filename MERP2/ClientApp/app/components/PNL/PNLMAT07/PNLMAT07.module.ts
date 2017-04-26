import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT07Component } from './PNLMAT07.component';
import { PNLMAT07EntryComponent } from './entry/PNLMAT07.entry.component';
import { PNLMAT07ConditionComponent } from './condition/PNLMAT07.condition.component';
import { PNLMAT07QueryComponent } from './query/PNLMAT07.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT07.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT07Component, PNLMAT07EntryComponent, PNLMAT07ConditionComponent, PNLMAT07QueryComponent]
})
export class PNLMAT07Module { }
