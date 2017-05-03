import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT13Component } from './COPMAT13.component';
import { COPMAT13EntryComponent } from './entry/COPMAT13.entry.component';
import { COPMAT13ConditionComponent } from './condition/COPMAT13.condition.component';
import { COPMAT13QueryComponent } from './query/COPMAT13.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './COPMAT13.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [COPMAT13Component, COPMAT13EntryComponent, COPMAT13ConditionComponent, COPMAT13QueryComponent]
})
export class COPMAT13Module { }
