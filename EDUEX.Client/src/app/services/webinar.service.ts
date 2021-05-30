import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ICreateWebinar } from '../models/ICreateWebinar';
import { IWebinar } from '../models/IWebinar';
import { IWebinarWithSessions } from '../models/IWebinarWithSessions';

@Injectable({
  providedIn: 'root'
})

export class WebinarService{

  constructor(private _http: HttpClient) {  }

  getWebinarWithSessions(id: number){
    return this._http.get<IWebinarWithSessions>('/api/webinar/webinarWithSessions/' + id);
  }

  postWebinar(webinar: ICreateWebinar){
    return this._http.post<IWebinarWithSessions>('/api/webinar/', webinar);
  }

  postUserWebinar(userId: number, webinarId: number){
    return this._http.post<any>('/api/userWebinar/', {userId: userId, webinarId: webinarId, enrollDate: Date.now()});
  }

  getWebinars(){
    return this._http.get<IWebinar[]>('/api/webinar/');
  }

  getSubjects(){
    return this._http.get<string[]>('/api/webinar/subjects/');
  }

}