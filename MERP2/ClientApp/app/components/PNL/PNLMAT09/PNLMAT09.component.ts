import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT09EntryComponent } from './entry/PNLMAT09.entry.component';
import { PNLMAT09ConditionComponent } from './condition/PNLMAT09.condition.component';
import { PNLMAT09QueryComponent } from './query/PNLMAT09.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat09',
    templateUrl: './pnlmat09.component.html',
    styleUrls: ['./pnlmat09.component.css']
})
export class PNLMAT09Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
