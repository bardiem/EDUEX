import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ICreateWebinar } from '../models/ICreateWebinar';
import { ICreateWebinarWithSessions } from '../models/ICreateWebinarWithSessions';
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

  getWebinars(subjectName: string = null, orderType: number = 0){
    let query = "?subject=" +subjectName + "&orderType="+ orderType;
    console.log(query);
    return this._http.get<IWebinar[]>('/api/webinar/' +query);
  }

  getSubjects(){
    return this._http.get<string[]>('/api/webinar/subjects/');
  }

}