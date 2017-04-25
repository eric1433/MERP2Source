import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { ACTMAT02EntryComponent } from './entry/ACTMAT02.entry.component';
import { ACTMAT02ConditionComponent } from './condition/ACTMAT02.condition.component';
import { ACTMAT02QueryComponent } from './query/ACTMAT02.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'actmat02',
    templateUrl: './actmat02.component.html',
    styleUrls: ['./actmat02.component.css']
})
export class ACTMAT02Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
