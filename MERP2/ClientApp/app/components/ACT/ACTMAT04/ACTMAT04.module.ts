import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ACTMAT04Component } from './ACTMAT04.component';
import { ACTMAT04EntryComponent } from './entry/ACTMAT04.entry.component';
import { ACTMAT04ConditionComponent } from './condition/ACTMAT04.condition.component';
import { ACTMAT04QueryComponent } from './query/ACTMAT04.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './ACTMAT04.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [ACTMAT04Component, ACTMAT04EntryComponent, ACTMAT04ConditionComponent, ACTMAT04QueryComponent]
})
export class ACTMAT04Module { }
