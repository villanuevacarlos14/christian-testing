import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Weather } from '../models/weather';
@Injectable({
  providedIn: 'root'
})
export class WeatherForecastService {


  constructor(private http: HttpClient) { }
  public getWeathers(){
    return this.http.get<Weather[]>(`${environment.baseUrl}/WeatherForecast`);
  }

  public addWeather(weather: Weather){
    return this.http.post<Weather[]>(`${environment.baseUrl}/WeatherForecast`,weather);
  }
}
