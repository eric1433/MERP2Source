import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { COPMAT04EntryComponent } from './entry/COPMAT04.entry.component';
import { COPMAT04ConditionComponent } from './condition/COPMAT04.condition.component';
import { COPMAT04QueryComponent } from './query/COPMAT04.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'copmat04',
    templateUrl: './copmat04.component.html',
    styleUrls: ['./copmat04.component.css']
})
export class COPMAT04Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
