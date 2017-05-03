import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT11Component } from './COPMAT11.component';
import { COPMAT11EntryComponent } from './entry/COPMAT11.entry.component';
import { COPMAT11ConditionComponent } from './condition/COPMAT11.condition.component';
import { COPMAT11QueryComponent } from './query/COPMAT11.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './COPMAT11.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [COPMAT11Component, COPMAT11EntryComponent, COPMAT11ConditionComponent, COPMAT11QueryComponent]
})
export class COPMAT11Module { }
