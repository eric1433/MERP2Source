import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT31EntryComponent } from './entry/PNLMAT31.entry.component';
import { PNLMAT31ConditionComponent } from './condition/PNLMAT31.condition.component';
import { PNLMAT31QueryComponent } from './query/PNLMAT31.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat31',
    templateUrl: './pnlmat31.component.html',
    styleUrls: ['./pnlmat31.component.css']
})
export class PNLMAT31Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
