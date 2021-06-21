import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ICreateWebinar } from '../models/ICreateWebinar';
import { ICreateWebinarWithSessions } from '../models/ICreateWebinarWithSessions';
import { ISubject } from '../models/ISubject';
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
    return this._http.post<ICreateWebinar>('/api/webinar/', webinar);
  }

  postWebinarWithSessions(webinar: ICreateWebinarWithSessions){
    return this._http.post<ICreateWebinarWithSessions>('/api/webinar/postWithSessions', webinar);
  }

  postUserWebinar(userId: number, webinarId: number){
    return this._http.post<any>('/api/userWebinar/', {userId: userId, webinarId: webinarId, enrollDate: Date.now()});
  }

  getWebinars(subjectId: number = null, orderType: number = 0){
    let query = "?subjectId=" +subjectId + "&orderType="+ orderType;
    console.log(query);
    return this._http.get<IWebinar[]>('/api/webinar/' +query);
  }

  getSubjects(){
    return this._http.get<ISubject[]>('api/subjects');
  }

}