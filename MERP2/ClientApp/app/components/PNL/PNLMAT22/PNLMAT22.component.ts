import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { PNLMAT22EntryComponent } from './entry/PNLMAT22.entry.component';
import { PNLMAT22ConditionComponent } from './condition/PNLMAT22.condition.component';
import { PNLMAT22QueryComponent } from './query/PNLMAT22.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'pnlmat22',
    templateUrl: './pnlmat22.component.html',
    styleUrls: ['./pnlmat22.component.css']
})
export class PNLMAT22Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
