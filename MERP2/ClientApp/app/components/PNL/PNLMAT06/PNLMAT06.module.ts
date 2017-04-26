import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT06Component } from './PNLMAT06.component';
import { PNLMAT06EntryComponent } from './entry/PNLMAT06.entry.component';
import { PNLMAT06ConditionComponent } from './condition/PNLMAT06.condition.component';
import { PNLMAT06QueryComponent } from './query/PNLMAT06.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT06.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT06Component, PNLMAT06EntryComponent, PNLMAT06ConditionComponent, PNLMAT06QueryComponent]
})
export class PNLMAT06Module { }
