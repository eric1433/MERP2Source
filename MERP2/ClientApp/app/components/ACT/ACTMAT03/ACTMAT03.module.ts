import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ACTMAT03Component } from './ACTMAT03.component';
import { ACTMAT03EntryComponent } from './entry/ACTMAT03.entry.component';
import { ACTMAT03ConditionComponent } from './condition/ACTMAT03.condition.component';
import { ACTMAT03QueryComponent } from './query/ACTMAT03.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './ACTMAT03.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [ACTMAT03Component, ACTMAT03EntryComponent, ACTMAT03ConditionComponent, ACTMAT03QueryComponent]
})
export class ACTMAT03Module { }
