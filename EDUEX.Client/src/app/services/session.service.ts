import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ISession } from '../models/ISession';

@Injectable({
  providedIn: 'root'
})

export class SessionService{

  constructor(private _http: HttpClient) {  }

  postSession(session: ISession){
    return this._http.post<ISession>('/api/session', session);
  }

}