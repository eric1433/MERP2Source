import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ACTMAT01Component } from './ACTMAT01.component';
import { ACTMAT01EntryComponent } from './entry/ACTMAT01.entry.component';
import { ACTMAT01ConditionComponent } from './condition/ACTMAT01.condition.component';
import { ACTMAT01QueryComponent } from './query/ACTMAT01.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './ACTMAT01.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [ACTMAT01Component, ACTMAT01EntryComponent, ACTMAT01ConditionComponent, ACTMAT01QueryComponent]
})
export class ACTMAT01Module { }
