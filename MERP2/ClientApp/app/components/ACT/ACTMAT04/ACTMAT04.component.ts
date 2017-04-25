import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { ACTMAT04EntryComponent } from './entry/ACTMAT04.entry.component';
import { ACTMAT04ConditionComponent } from './condition/ACTMAT04.condition.component';
import { ACTMAT04QueryComponent } from './query/ACTMAT04.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'actmat04',
    templateUrl: './actmat04.component.html',
    styleUrls: ['./actmat04.component.css']
})
export class ACTMAT04Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
