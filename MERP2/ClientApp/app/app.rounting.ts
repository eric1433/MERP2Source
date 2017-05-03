import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { PUBMAT01Component } from './components/PUB/PUBMAT01/PUBMAT01.component';
import { PUBMAT02Component } from './components/PUB/PUBMAT02/PUBMAT02.component';
import { PUBMAT03Component } from './components/PUB/PUBMAT03/PUBMAT03.component';
import { PUBMAT04Component } from './components/PUB/PUBMAT04/PUBMAT04.component';
import { PUBMAT05Component } from './components/PUB/PUBMAT05/PUBMAT05.component';
import { PUBMAT06Component } from './components/PUB/PUBMAT06/PUBMAT06.component';
import { PUBMAT07Component } from './components/PUB/PUBMAT07/PUBMAT07.component';
import { PUBMAT08Component } from './components/PUB/PUBMAT08/PUBMAT08.component';
import { ACTMAT01Component } from './components/ACT/ACTMAT01/ACTMAT01.component';
import { ACTMAT02Component } from './components/ACT/ACTMAT02/ACTMAT02.component';
import { ACTMAT03Component } from './components/ACT/ACTMAT03/ACTMAT03.component';
import { ACTMAT04Component } from './components/ACT/ACTMAT04/ACTMAT04.component';
import { PNLMAT01Component } from './components/PNL/PNLMAT01/PNLMAT01.component';
import { PNLMAT02Component } from './components/PNL/PNLMAT02/PNLMAT02.component';
import { PNLMAT03Component } from './components/PNL/PNLMAT03/PNLMAT03.component';
import { PNLMAT04Component } from './components/PNL/PNLMAT04/PNLMAT04.component';
import { PNLMAT05Component } from './components/PNL/PNLMAT05/PNLMAT05.component';
import { PNLMAT06Component } from './components/PNL/PNLMAT06/PNLMAT06.component';
import { PNLMAT07Component } from './components/PNL/PNLMAT07/PNLMAT07.component';
import { PNLMAT08Component } from './components/PNL/PNLMAT08/PNLMAT08.component';
import { PNLMAT09Component } from './components/PNL/PNLMAT09/PNLMAT09.component';
import { PNLMAT10Component } from './components/PNL/PNLMAT10/PNLMAT10.component';
import { PNLMAT11Component } from './components/PNL/PNLMAT11/PNLMAT11.component';
import { PNLMAT13Component } from './components/PNL/PNLMAT13/PNLMAT13.component';
import { PNLMAT14Component } from './components/PNL/PNLMAT14/PNLMAT14.component';
import { PNLMAT15Component } from './components/PNL/PNLMAT15/PNLMAT15.component';
import { PNLMAT16Component } from './components/PNL/PNLMAT16/PNLMAT16.component';
import { PNLMAT17Component } from './components/PNL/PNLMAT17/PNLMAT17.component';
import { PNLMAT18Component } from './components/PNL/PNLMAT18/PNLMAT18.component';
import { PNLMAT22Component } from './components/PNL/PNLMAT22/PNLMAT22.component';
import { PNLMAT23Component } from './components/PNL/PNLMAT23/PNLMAT23.component';
import { PNLMAT26Component } from './components/PNL/PNLMAT26/PNLMAT26.component';
import { PNLMAT27Component } from './components/PNL/PNLMAT27/PNLMAT27.component';
import { PNLMAT28Component } from './components/PNL/PNLMAT28/PNLMAT28.component';
import { PNLMAT31Component } from './components/PNL/PNLMAT31/PNLMAT31.component';
import { PNLMAT32Component } from './components/PNL/PNLMAT32/PNLMAT32.component';
import { COPMAT01Component } from './components/COP/COPMAT01/COPMAT01.component';
import { COPMAT02Component } from './components/COP/COPMAT02/COPMAT02.component';
import { COPMAT03Component } from './components/COP/COPMAT03/COPMAT03.component';
import { COPMAT04Component } from './components/COP/COPMAT04/COPMAT04.component';
import { COPMAT05Component } from './components/COP/COPMAT05/COPMAT05.component';
import { COPMAT06Component } from './components/COP/COPMAT06/COPMAT06.component';
import { COPMAT07Component } from './components/COP/COPMAT07/COPMAT07.component';
import { COPMAT11Component } from './components/COP/COPMAT11/COPMAT11.component';
import { COPMAT12Component } from './components/COP/COPMAT12/COPMAT12.component';
import { COPMAT13Component } from './components/COP/COPMAT13/COPMAT13.component';

import { PUBMAT01Module } from './components/PUB/PUBMAT01/PUBMAT01.module';
import { PUBMAT02Module } from './components/PUB/PUBMAT02/PUBMAT02.module';
import { PUBMAT03Module } from './components/PUB/PUBMAT03/PUBMAT03.module';
import { PUBMAT04Module } from './components/PUB/PUBMAT04/PUBMAT04.module';
import { PUBMAT05Module } from './components/PUB/PUBMAT05/PUBMAT05.module';
import { PUBMAT06Module } from './components/PUB/PUBMAT06/PUBMAT06.module';
import { PUBMAT07Module } from './components/PUB/PUBMAT07/PUBMAT07.module';
import { PUBMAT08Module } from './components/PUB/PUBMAT08/PUBMAT08.module';
import { ACTMAT01Module } from './components/ACT/ACTMAT01/ACTMAT01.module';
import { ACTMAT02Module } from './components/ACT/ACTMAT02/ACTMAT02.module';
import { ACTMAT03Module } from './components/ACT/ACTMAT03/ACTMAT03.module';
import { ACTMAT04Module } from './components/ACT/ACTMAT04/ACTMAT04.module';
import { PNLMAT01Module } from './components/PNL/PNLMAT01/PNLMAT01.module';
import { PNLMAT02Module } from './components/PNL/PNLMAT02/PNLMAT02.module';
import { PNLMAT03Module } from './components/PNL/PNLMAT03/PNLMAT03.module';
import { PNLMAT04Module } from './components/PNL/PNLMAT04/PNLMAT04.module';
import { PNLMAT05Module } from './components/PNL/PNLMAT05/PNLMAT05.module';
import { PNLMAT06Module } from './components/PNL/PNLMAT06/PNLMAT06.module';
import { PNLMAT07Module } from './components/PNL/PNLMAT07/PNLMAT07.module';
import { PNLMAT08Module } from './components/PNL/PNLMAT08/PNLMAT08.module';
import { PNLMAT09Module } from './components/PNL/PNLMAT09/PNLMAT09.module';
import { PNLMAT10Module } from './components/PNL/PNLMAT10/PNLMAT10.module';
import { PNLMAT11Module } from './components/PNL/PNLMAT11/PNLMAT11.module';
import { PNLMAT13Module } from './components/PNL/PNLMAT13/PNLMAT13.module';
import { PNLMAT14Module } from './components/PNL/PNLMAT14/PNLMAT14.module';
import { PNLMAT15Module } from './components/PNL/PNLMAT15/PNLMAT15.module';
import { PNLMAT16Module } from './components/PNL/PNLMAT16/PNLMAT16.module';
import { PNLMAT17Module } from './components/PNL/PNLMAT17/PNLMAT17.module';
import { PNLMAT18Module } from './components/PNL/PNLMAT18/PNLMAT18.module';
import { PNLMAT22Module } from './components/PNL/PNLMAT22/PNLMAT22.module';
import { PNLMAT23Module } from './components/PNL/PNLMAT23/PNLMAT23.module';
import { PNLMAT26Module } from './components/PNL/PNLMAT26/PNLMAT26.module';
import { PNLMAT27Module } from './components/PNL/PNLMAT27/PNLMAT27.module';
import { PNLMAT28Module } from './components/PNL/PNLMAT28/PNLMAT28.module';
import { PNLMAT31Module } from './components/PNL/PNLMAT31/PNLMAT31.module';
import { PNLMAT32Module } from './components/PNL/PNLMAT32/PNLMAT32.module';
import { COPMAT01Module } from './components/COP/COPMAT01/COPMAT01.module';
import { COPMAT02Module } from './components/COP/COPMAT02/COPMAT02.module';
import { COPMAT03Module } from './components/COP/COPMAT03/COPMAT03.module';
import { COPMAT04Module } from './components/COP/COPMAT04/COPMAT04.module';
import { COPMAT05Module } from './components/COP/COPMAT05/COPMAT05.module';
import { COPMAT06Module } from './components/COP/COPMAT06/COPMAT06.module';
import { COPMAT07Module } from './components/COP/COPMAT07/COPMAT07.module';
import { COPMAT11Module } from './components/COP/COPMAT11/COPMAT11.module';
import { COPMAT12Module } from './components/COP/COPMAT12/COPMAT12.module';
import { COPMAT13Module } from './components/COP/COPMAT13/COPMAT13.module';


export function loadPUBMAT01Module()
{
    return PUBMAT01Module;
}
export function loadPUBMAT02Module() {
    return PUBMAT02Module;
}
export function loadPUBMAT03Module() {
    return PUBMAT03Module;
}
export function loadPUBMAT04Module() {
    return PUBMAT04Module;
}
export function loadPUBMAT05Module() {
    return PUBMAT05Module;
}
export function loadPUBMAT06Module() {
    return PUBMAT06Module;
}
export function loadPUBMAT07Module() {
    return PUBMAT07Module;
}
export function loadPUBMAT08Module() {
    return PUBMAT08Module;
}
export function loadACTMAT01Module() {
    return ACTMAT01Module;
}
export function loadACTMAT02Module() {
    return ACTMAT02Module;
}
export function loadACTMAT03Module() {
    return ACTMAT03Module;
}
export function loadACTMAT04Module() {
    return ACTMAT04Module;
}
export function loadPNLMAT01Module() {
    return PNLMAT01Module;
}
export function loadPNLMAT02Module() {
    return PNLMAT02Module;
}
export function loadPNLMAT03Module() {
    return PNLMAT03Module;
}
export function loadPNLMAT04Module() {
    return PNLMAT04Module;
}
export function loadPNLMAT05Module() {
    return PNLMAT05Module;
}
export function loadPNLMAT06Module() {
    return PNLMAT06Module;
}
export function loadPNLMAT07Module() {
    return PNLMAT07Module;
}
export function loadPNLMAT08Module() {
    return PNLMAT08Module;
}
export function loadPNLMAT09Module() {
    return PNLMAT09Module;
}
export function loadPNLMAT10Module() {
    return PNLMAT10Module;
}
export function loadPNLMAT11Module() {
    return PNLMAT11Module;
}
export function loadPNLMAT13Module() {
    return PNLMAT13Module;
}
export function loadPNLMAT14Module() {
    return PNLMAT14Module;
}
export function loadPNLMAT15Module() {
    return PNLMAT15Module;
}
export function loadPNLMAT16Module() {
    return PNLMAT16Module;
}
export function loadPNLMAT17Module() {
    return PNLMAT17Module;
}
export function loadPNLMAT18Module() {
    return PNLMAT18Module;
}
export function loadPNLMAT22Module() {
    return PNLMAT22Module;
}
export function loadPNLMAT23Module() {
    return PNLMAT23Module;
}
export function loadPNLMAT26Module() {
    return PNLMAT26Module;
}
export function loadPNLMAT27Module() {
    return PNLMAT27Module;
}
export function loadPNLMAT28Module() {
    return PNLMAT28Module;
}
export function loadPNLMAT31Module() {
    return PNLMAT31Module;
}
export function loadPNLMAT32Module() {
    return PNLMAT32Module;
}
export function loadCOPMAT01Module() {
    return COPMAT01Module;
}
export function loadCOPMAT02Module() {
    return COPMAT02Module;
}
export function loadCOPMAT03Module() {
    return COPMAT03Module;
}
export function loadCOPMAT04Module() {
    return COPMAT04Module;
}
export function loadCOPMAT05Module() {
    return COPMAT05Module;
}
export function loadCOPMAT06Module() {
    return COPMAT06Module;
}
export function loadCOPMAT07Module() {
    return COPMAT07Module;
}
export function loadCOPMAT11Module() {
    return COPMAT11Module;
}
export function loadCOPMAT12Module() {
    return COPMAT12Module;
}
export function loadCOPMAT13Module() {
    return COPMAT13Module;
}

const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    { path: 'home', component: HomeComponent },
    //{ path: 'PUBMAT01', component: PUNMAT01Component },
    { path: 'PUBMAT01', loadChildren: loadPUBMAT01Module },
    { path: 'PUBMAT02', loadChildren: loadPUBMAT02Module },
    { path: 'PUBMAT03', loadChildren: loadPUBMAT03Module },
    { path: 'PUBMAT04', loadChildren: loadPUBMAT04Module },
    { path: 'PUBMAT05', loadChildren: loadPUBMAT05Module },
    { path: 'PUBMAT06', loadChildren: loadPUBMAT06Module },
    { path: 'PUBMAT07', loadChildren: loadPUBMAT07Module },
    { path: 'PUBMAT08', loadChildren: loadPUBMAT08Module },
    { path: 'ACTMAT01', loadChildren: loadACTMAT01Module },
    { path: 'ACTMAT02', loadChildren: loadACTMAT02Module },
    { path: 'ACTMAT03', loadChildren: loadACTMAT03Module },
    { path: 'ACTMAT04', loadChildren: loadACTMAT04Module },
    { path: 'PNLMAT01', loadChildren: loadPNLMAT01Module },
    { path: 'PNLMAT02', loadChildren: loadPNLMAT02Module },
    { path: 'PNLMAT03', loadChildren: loadPNLMAT03Module },
    { path: 'PNLMAT04', loadChildren: loadPNLMAT04Module },
    { path: 'PNLMAT05', loadChildren: loadPNLMAT05Module },
    { path: 'PNLMAT06', loadChildren: loadPNLMAT06Module },
    { path: 'PNLMAT07', loadChildren: loadPNLMAT07Module },
    { path: 'PNLMAT08', loadChildren: loadPNLMAT08Module },
    { path: 'PNLMAT09', loadChildren: loadPNLMAT09Module },
    { path: 'PNLMAT10', loadChildren: loadPNLMAT10Module },
    { path: 'PNLMAT11', loadChildren: loadPNLMAT11Module },
    { path: 'PNLMAT13', loadChildren: loadPNLMAT13Module },
    { path: 'PNLMAT14', loadChildren: loadPNLMAT14Module },
    { path: 'PNLMAT15', loadChildren: loadPNLMAT15Module },
    { path: 'PNLMAT16', loadChildren: loadPNLMAT16Module },
    { path: 'PNLMAT17', loadChildren: loadPNLMAT17Module },
    { path: 'PNLMAT18', loadChildren: loadPNLMAT18Module },
    { path: 'PNLMAT22', loadChildren: loadPNLMAT22Module },
    { path: 'PNLMAT23', loadChildren: loadPNLMAT23Module },
    { path: 'PNLMAT26', loadChildren: loadPNLMAT26Module },
    { path: 'PNLMAT27', loadChildren: loadPNLMAT27Module },
    { path: 'PNLMAT28', loadChildren: loadPNLMAT28Module },
    { path: 'PNLMAT31', loadChildren: loadPNLMAT31Module },
    { path: 'PNLMAT32', loadChildren: loadPNLMAT32Module },
    { path: 'COPMAT01', loadChildren: loadCOPMAT01Module },
    { path: 'COPMAT02', loadChildren: loadCOPMAT02Module },
    { path: 'COPMAT03', loadChildren: loadCOPMAT03Module },
    { path: 'COPMAT04', loadChildren: loadCOPMAT04Module },
    { path: 'COPMAT05', loadChildren: loadCOPMAT05Module },
    { path: 'COPMAT06', loadChildren: loadCOPMAT06Module },
    { path: 'COPMAT07', loadChildren: loadCOPMAT07Module },
    { path: 'COPMAT11', loadChildren: loadCOPMAT11Module },
    { path: 'COPMAT12', loadChildren: loadCOPMAT12Module },
    { path: 'COPMAT13', loadChildren: loadCOPMAT13Module },
    { path: 'fetch-data', component: FetchDataComponent },
    { path: '**', redirectTo: 'home' },
];

export const routing= RouterModule.forRoot(routes);