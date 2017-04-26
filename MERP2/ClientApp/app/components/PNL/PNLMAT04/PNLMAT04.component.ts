import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT04EntryComponent } from './entry/PNLMAT04.entry.component';
import { PNLMAT04ConditionComponent } from './condition/PNLMAT04.condition.component';
import { PNLMAT04QueryComponent } from './query/PNLMAT04.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat04',
    templateUrl: './pnlmat04.component.html',
    styleUrls: ['./pnlmat04.component.css']
})
export class PNLMAT04Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
