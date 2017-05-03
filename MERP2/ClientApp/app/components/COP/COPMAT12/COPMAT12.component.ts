import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { COPMAT12EntryComponent } from './entry/COPMAT12.entry.component';
import { COPMAT12ConditionComponent } from './condition/COPMAT12.condition.component';
import { COPMAT12QueryComponent } from './query/COPMAT12.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'copmat12',
    templateUrl: './copmat12.component.html',
    styleUrls: ['./copmat12.component.css']
})
export class COPMAT12Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
