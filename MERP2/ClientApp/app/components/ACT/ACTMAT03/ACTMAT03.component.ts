import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { ACTMAT03EntryComponent } from './entry/ACTMAT03.entry.component';
import { ACTMAT03ConditionComponent } from './condition/ACTMAT03.condition.component';
import { ACTMAT03QueryComponent } from './query/ACTMAT03.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'actmat03',
    templateUrl: './actmat03.component.html',
    styleUrls: ['./actmat03.component.css']
})
export class ACTMAT03Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
