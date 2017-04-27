import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT26EntryComponent } from './entry/PNLMAT26.entry.component';
import { PNLMAT26ConditionComponent } from './condition/PNLMAT26.condition.component';
import { PNLMAT26QueryComponent } from './query/PNLMAT26.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat26',
    templateUrl: './pnlmat26.component.html',
    styleUrls: ['./pnlmat26.component.css']
})
export class PNLMAT26Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
