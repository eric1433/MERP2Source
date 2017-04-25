import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT05EntryComponent } from './entry/PNLMAT05.entry.component';
import { PNLMAT05ConditionComponent } from './condition/PNLMAT05.condition.component';
import { PNLMAT05QueryComponent } from './query/PNLMAT05.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat05',
    templateUrl: './pnlmat05.component.html',
    styleUrls: ['./pnlmat05.component.css']
})
export class PNLMAT05Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
