import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PNLMAT03Component } from './PNLMAT03.component';
import { PNLMAT03EntryComponent } from './entry/PNLMAT03.entry.component';
import { PNLMAT03ConditionComponent } from './condition/PNLMAT03.condition.component';
import { PNLMAT03QueryComponent } from './query/PNLMAT03.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './PNLMAT03.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [PNLMAT03Component, PNLMAT03EntryComponent, PNLMAT03ConditionComponent, PNLMAT03QueryComponent]
})
export class PNLMAT03Module { }
