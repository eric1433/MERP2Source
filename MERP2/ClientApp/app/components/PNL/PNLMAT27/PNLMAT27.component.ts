import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT27EntryComponent } from './entry/PNLMAT27.entry.component';
import { PNLMAT27ConditionComponent } from './condition/PNLMAT27.condition.component';
import { PNLMAT27QueryComponent } from './query/PNLMAT27.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat27',
    templateUrl: './pnlmat27.component.html',
    styleUrls: ['./pnlmat27.component.css']
})
export class PNLMAT27Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
