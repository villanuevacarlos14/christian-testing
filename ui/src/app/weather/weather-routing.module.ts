import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WeatherListComponent } from './component/weather-list/weather-list.component';

const routes: Routes = [ { 
  path: 'list', component: WeatherListComponent },
  {path: "**", redirectTo: 'list'}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class WeatherRoutingModule { }
