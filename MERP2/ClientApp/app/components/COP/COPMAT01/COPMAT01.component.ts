import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { COPMAT01EntryComponent } from './entry/COPMAT01.entry.component';
import { COPMAT01ConditionComponent } from './condition/COPMAT01.condition.component';
import { COPMAT01QueryComponent } from './query/COPMAT01.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'copmat01',
    templateUrl: './copmat01.component.html',
    styleUrls: ['./copmat01.component.css']
})
export class COPMAT01Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
