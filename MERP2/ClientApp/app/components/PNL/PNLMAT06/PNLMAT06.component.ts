import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT06EntryComponent } from './entry/PNLMAT06.entry.component';
import { PNLMAT06ConditionComponent } from './condition/PNLMAT06.condition.component';
import { PNLMAT06QueryComponent } from './query/PNLMAT06.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat06',
    templateUrl: './pnlmat06.component.html',
    styleUrls: ['./pnlmat06.component.css']
})
export class PNLMAT06Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
