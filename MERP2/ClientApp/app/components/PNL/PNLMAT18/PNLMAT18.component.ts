import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT18EntryComponent } from './entry/PNLMAT18.entry.component';
import { PNLMAT18ConditionComponent } from './condition/PNLMAT18.condition.component';
import { PNLMAT18QueryComponent } from './query/PNLMAT18.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat18',
    templateUrl: './pnlmat18.component.html',
    styleUrls: ['./pnlmat18.component.css']
})
export class PNLMAT18Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
