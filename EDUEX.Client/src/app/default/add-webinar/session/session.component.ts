import { Component, OnInit } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
@Component({
  selector: 'app-session',
  templateUrl: './session.component.html',
  styleUrls: ['./session.component.scss']
})

  @Injectable({providedIn : "root"})
  export class SessionComponent{
    Submit(dat){
      console.warn(dat)
      this.http.post(this._url,dat)
      .subscribe((res)=>{console.warn(res)
  
      })
       
    }
    
         constructor(private http: HttpClient) {}
      private _url: string = '/api/session'; 
  }
