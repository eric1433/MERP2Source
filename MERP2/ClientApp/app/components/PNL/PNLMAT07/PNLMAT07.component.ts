import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT07EntryComponent } from './entry/PNLMAT07.entry.component';
import { PNLMAT07ConditionComponent } from './condition/PNLMAT07.condition.component';
import { PNLMAT07QueryComponent } from './query/PNLMAT07.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat07',
    templateUrl: './pnlmat07.component.html',
    styleUrls: ['./pnlmat07.component.css']
})
export class PNLMAT07Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
