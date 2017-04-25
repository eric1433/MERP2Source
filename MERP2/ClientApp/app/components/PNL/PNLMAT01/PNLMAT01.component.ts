import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT01EntryComponent } from './entry/PNLMAT01.entry.component';
import { PNLMAT01ConditionComponent } from './condition/PNLMAT01.condition.component';
import { PNLMAT01QueryComponent } from './query/PNLMAT01.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat01',
    templateUrl: './pnlmat01.component.html',
    styleUrls: ['./pnlmat01.component.css']
})
export class PNLMAT01Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
