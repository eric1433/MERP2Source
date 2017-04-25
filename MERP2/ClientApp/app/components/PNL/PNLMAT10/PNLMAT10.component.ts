import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT10EntryComponent } from './entry/PNLMAT10.entry.component';
import { PNLMAT10ConditionComponent } from './condition/PNLMAT10.condition.component';
import { PNLMAT10QueryComponent } from './query/PNLMAT10.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat10',
    templateUrl: './pnlmat10.component.html',
    styleUrls: ['./pnlmat10.component.css']
})
export class PNLMAT10Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
