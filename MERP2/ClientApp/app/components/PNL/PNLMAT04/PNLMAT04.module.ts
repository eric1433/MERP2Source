import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT04Component } from './PNLMAT04.component';
import { PNLMAT04EntryComponent } from './entry/PNLMAT04.entry.component';
import { PNLMAT04ConditionComponent } from './condition/PNLMAT04.condition.component';
import { PNLMAT04QueryComponent } from './query/PNLMAT04.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT04.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT04Component, PNLMAT04EntryComponent, PNLMAT04ConditionComponent, PNLMAT04QueryComponent]
})
export class PNLMAT04Module { }
