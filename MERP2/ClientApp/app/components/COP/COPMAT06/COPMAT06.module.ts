import { NgModule } from '@angular/core';
import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { COPMAT06Component } from './COPMAT06.component';
import { COPMAT06EntryComponent } from './entry/COPMAT06.entry.component';
import { COPMAT06ConditionComponent } from './condition/COPMAT06.condition.component';
import { COPMAT06QueryComponent } from './query/COPMAT06.query.component';
import { TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule } from 'primeng/primeng';
import { SharedCommonModule } from '../../shared/shared.module';
import { routing } from './COPMAT06.routing';

@NgModule({
    imports: [routing, TabMenuModule, MenuModule, TabViewModule, DataTableModule, SharedModule, SharedCommonModule],
    declarations: [COPMAT06Component, COPMAT06EntryComponent, COPMAT06ConditionComponent, COPMAT06QueryComponent]
})
export class COPMAT06Module { }
