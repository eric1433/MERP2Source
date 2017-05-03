import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { COPMAT07EntryComponent } from './entry/COPMAT07.entry.component';
import { COPMAT07ConditionComponent } from './condition/COPMAT07.condition.component';
import { COPMAT07QueryComponent } from './query/COPMAT07.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'copmat07',
    templateUrl: './copmat07.component.html',
    styleUrls: ['./copmat07.component.css']
})
export class COPMAT07Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
