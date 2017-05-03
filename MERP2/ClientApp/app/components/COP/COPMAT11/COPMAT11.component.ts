import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { COPMAT11EntryComponent } from './entry/COPMAT11.entry.component';
import { COPMAT11ConditionComponent } from './condition/COPMAT11.condition.component';
import { COPMAT11QueryComponent } from './query/COPMAT11.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'copmat11',
    templateUrl: './copmat11.component.html',
    styleUrls: ['./copmat11.component.css']
})
export class COPMAT11Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
