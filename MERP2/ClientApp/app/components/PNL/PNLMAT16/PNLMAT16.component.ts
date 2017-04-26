import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT16EntryComponent } from './entry/PNLMAT16.entry.component';
import { PNLMAT16ConditionComponent } from './condition/PNLMAT16.condition.component';
import { PNLMAT16QueryComponent } from './query/PNLMAT16.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat16',
    templateUrl: './pnlmat16.component.html',
    styleUrls: ['./pnlmat16.component.css']
})
export class PNLMAT16Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
