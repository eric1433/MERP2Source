import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { COPMAT13EntryComponent } from './entry/COPMAT13.entry.component';
import { COPMAT13ConditionComponent } from './condition/COPMAT13.condition.component';
import { COPMAT13QueryComponent } from './query/COPMAT13.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'copmat13',
    templateUrl: './copmat13.component.html',
    styleUrls: ['./copmat13.component.css']
})
export class COPMAT13Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
