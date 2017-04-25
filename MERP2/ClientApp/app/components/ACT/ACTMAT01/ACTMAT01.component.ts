import { CommonModule } from '@angular/common';
import { platformBrowserDynamic } from "@angular/platform-browser-dynamic";
import { Component } from '@angular/core';
import { ACTMAT01EntryComponent} from './entry/ACTMAT01.entry.component';
import { ACTMAT01ConditionComponent } from './condition/ACTMAT01.condition.component';
import { ACTMAT01QueryComponent } from './query/ACTMAT01.query.component';
import { MenuItem } from 'primeng/primeng';
import { CommandbuttonComponentComponent } from '../../shared/commandbutton/commandbutton.component';
import { DataService } from './../../shared/service/dataservice/data.service';
import { MaintainBase } from '../../shared/system/maintainBase.class';

@Component({
    selector: 'actmat01',
    templateUrl: './actmat01.component.html',
    styleUrls: ['./actmat01.component.css']
})
export class ACTMAT01Component extends  MaintainBase {    

    constructor(private dataService: DataService) {
        super(dataService);
        this.scope.menuType = 'MSSVCH';
        
    }

    ngOnInit() {
        
    }
}
