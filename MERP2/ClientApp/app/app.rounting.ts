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
    { path: 'fetch-data', component: FetchDataComponent },
    { path: '**', redirectTo: 'home' },
];

export const routing= RouterModule.forRoot(routes);