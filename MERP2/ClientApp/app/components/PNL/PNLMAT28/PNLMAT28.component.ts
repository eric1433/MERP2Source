import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT28EntryComponent } from './entry/PNLMAT28.entry.component';
import { PNLMAT28ConditionComponent } from './condition/PNLMAT28.condition.component';
import { PNLMAT28QueryComponent } from './query/PNLMAT28.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat28',
    templateUrl: './pnlmat28.component.html',
    styleUrls: ['./pnlmat28.component.css']
})
export class PNLMAT28Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
