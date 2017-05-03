﻿import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { COPMAT02EntryComponent } from './entry/COPMAT02.entry.component';
import { COPMAT02ConditionComponent } from './condition/COPMAT02.condition.component';
import { COPMAT02QueryComponent } from './query/COPMAT02.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'copmat02',
    templateUrl: './copmat02.component.html',
    styleUrls: ['./copmat02.component.css']
})
export class COPMAT02Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
