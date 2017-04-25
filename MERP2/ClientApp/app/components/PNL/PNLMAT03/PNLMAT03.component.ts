import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT03EntryComponent } from './entry/PNLMAT03.entry.component';
import { PNLMAT03ConditionComponent } from './condition/PNLMAT03.condition.component';
import { PNLMAT03QueryComponent } from './query/PNLMAT03.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat03',
    templateUrl: './pnlmat03.component.html',
    styleUrls: ['./pnlmat03.component.css']
})
export class PNLMAT03Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
