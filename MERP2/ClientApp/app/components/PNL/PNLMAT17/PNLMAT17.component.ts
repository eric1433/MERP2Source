import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT17EntryComponent } from './entry/PNLMAT17.entry.component';
import { PNLMAT17ConditionComponent } from './condition/PNLMAT17.condition.component';
import { PNLMAT17QueryComponent } from './query/PNLMAT17.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat17',
    templateUrl: './pnlmat17.component.html',
    styleUrls: ['./pnlmat17.component.css']
})
export class PNLMAT17Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
