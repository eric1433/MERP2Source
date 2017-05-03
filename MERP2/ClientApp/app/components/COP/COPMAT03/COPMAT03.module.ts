import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT03Component } from './COPMAT03.component';
import { COPMAT03EntryComponent } from './entry/COPMAT03.entry.component';
import { COPMAT03ConditionComponent } from './condition/COPMAT03.condition.component';
import { COPMAT03QueryComponent } from './query/COPMAT03.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './COPMAT03.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [COPMAT03Component, COPMAT03EntryComponent, COPMAT03ConditionComponent, COPMAT03QueryComponent]
})
export class COPMAT03Module { }
