import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT08EntryComponent } from './entry/PNLMAT08.entry.component';
import { PNLMAT08ConditionComponent } from './condition/PNLMAT08.condition.component';
import { PNLMAT08QueryComponent } from './query/PNLMAT08.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat08',
    templateUrl: './pnlmat08.component.html',
    styleUrls: ['./pnlmat08.component.css']
})
export class PNLMAT08Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
