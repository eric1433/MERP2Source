import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT07Component } from './COPMAT07.component';
import { COPMAT07EntryComponent } from './entry/COPMAT07.entry.component';
import { COPMAT07ConditionComponent } from './condition/COPMAT07.condition.component';
import { COPMAT07QueryComponent } from './query/COPMAT07.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './COPMAT07.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [COPMAT07Component, COPMAT07EntryComponent, COPMAT07ConditionComponent, COPMAT07QueryComponent]
})
export class COPMAT07Module { }
