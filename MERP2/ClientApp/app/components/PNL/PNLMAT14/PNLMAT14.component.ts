import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT14EntryComponent } from './entry/PNLMAT14.entry.component';
import { PNLMAT14ConditionComponent } from './condition/PNLMAT14.condition.component';
import { PNLMAT14QueryComponent } from './query/PNLMAT14.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat14',
    templateUrl: './pnlmat14.component.html',
    styleUrls: ['./pnlmat14.component.css']
})
export class PNLMAT14Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
