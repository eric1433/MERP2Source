import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT11EntryComponent } from './entry/PNLMAT11.entry.component';
import { PNLMAT11ConditionComponent } from './condition/PNLMAT11.condition.component';
import { PNLMAT11QueryComponent } from './query/PNLMAT11.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat11',
    templateUrl: './pnlmat11.component.html',
    styleUrls: ['./pnlmat11.component.css']
})
export class PNLMAT11Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
