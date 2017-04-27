import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT13EntryComponent } from './entry/PNLMAT13.entry.component';
import { PNLMAT13ConditionComponent } from './condition/PNLMAT13.condition.component';
import { PNLMAT13QueryComponent } from './query/PNLMAT13.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat13',
    templateUrl: './pnlmat13.component.html',
    styleUrls: ['./pnlmat13.component.css']
})
export class PNLMAT13Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
