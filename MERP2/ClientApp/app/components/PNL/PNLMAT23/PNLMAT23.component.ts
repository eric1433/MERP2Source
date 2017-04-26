import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT23EntryComponent } from './entry/PNLMAT23.entry.component';
import { PNLMAT23ConditionComponent } from './condition/PNLMAT23.condition.component';
import { PNLMAT23QueryComponent } from './query/PNLMAT23.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat23',
    templateUrl: './pnlmat23.component.html',
    styleUrls: ['./pnlmat23.component.css']
})
export class PNLMAT23Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
