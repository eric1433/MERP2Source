import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { COPMAT05EntryComponent } from './entry/COPMAT05.entry.component';
import { COPMAT05ConditionComponent } from './condition/COPMAT05.condition.component';
import { COPMAT05QueryComponent } from './query/COPMAT05.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'copmat05',
    templateUrl: './copmat05.component.html',
    styleUrls: ['./copmat05.component.css']
})
export class COPMAT05Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
