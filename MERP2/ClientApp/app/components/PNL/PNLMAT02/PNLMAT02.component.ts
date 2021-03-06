﻿import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT02EntryComponent } from './entry/PNLMAT02.entry.component';
import { PNLMAT02ConditionComponent } from './condition/PNLMAT02.condition.component';
import { PNLMAT02QueryComponent } from './query/PNLMAT02.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat02',
    templateUrl: './pnlmat02.component.html',
    styleUrls: ['./pnlmat02.component.css']
})
export class PNLMAT02Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
