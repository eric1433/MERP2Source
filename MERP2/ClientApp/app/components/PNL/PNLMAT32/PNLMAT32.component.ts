import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT32EntryComponent } from './entry/PNLMAT32.entry.component';
import { PNLMAT32ConditionComponent } from './condition/PNLMAT32.condition.component';
import { PNLMAT32QueryComponent } from './query/PNLMAT32.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat32',
    templateUrl: './pnlmat32.component.html',
    styleUrls: ['./pnlmat32.component.css']
})
export class PNLMAT32Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
