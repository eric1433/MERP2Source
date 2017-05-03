import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { COPMAT03EntryComponent } from './entry/COPMAT03.entry.component';
import { COPMAT03ConditionComponent } from './condition/COPMAT03.condition.component';
import { COPMAT03QueryComponent } from './query/COPMAT03.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'copmat03',
    templateUrl: './copmat03.component.html',
    styleUrls: ['./copmat03.component.css']
})
export class COPMAT03Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
