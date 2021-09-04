import { Component, OnInit } from '@angular/core';
import { Weather } from 'src/app/models/weather';
import { WeatherForecastService } from 'src/app/service/weather-forecast.service';

@Component({
  selector: 'app-weather-list',
  templateUrl: './weather-list.component.html',
  styleUrls: ['./weather-list.component.scss']
})
export class WeatherListComponent implements OnInit {

  public weatherUpdate!: Weather[];
  constructor(private _weatherService: WeatherForecastService) { }

  ngOnInit(): void {
    this._weatherService.getWeathers().subscribe((data)=>{
      this.weatherUpdate = data;
    });
  }

}
