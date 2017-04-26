import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT15EntryComponent } from './entry/PNLMAT15.entry.component';
import { PNLMAT15ConditionComponent } from './condition/PNLMAT15.condition.component';
import { PNLMAT15QueryComponent } from './query/PNLMAT15.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat15',
    templateUrl: './pnlmat15.component.html',
    styleUrls: ['./pnlmat15.component.css']
})
export class PNLMAT15Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
