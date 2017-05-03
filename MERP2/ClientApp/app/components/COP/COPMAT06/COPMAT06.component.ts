import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { COPMAT06EntryComponent } from './entry/COPMAT06.entry.component';
import { COPMAT06ConditionComponent } from './condition/COPMAT06.condition.component';
import { COPMAT06QueryComponent } from './query/COPMAT06.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'copmat06',
    templateUrl: './copmat06.component.html',
    styleUrls: ['./copmat06.component.css']
})
export class COPMAT06Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
