import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IWebinarWithSessions } from '../models/IWebinarWithSessions';

@Injectable({
  providedIn: 'root'
})

export class WebinarService{

  constructor(private _http: HttpClient) {  }

  getWebinarWithSessions(id: number){
    return this._http.get<IWebinarWithSessions>('/api/webinar/webinarWithSessions/' + id);
  }

}