import { Component, OnInit } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Component({
  selector: 'app-session',
  templateUrl: './session.component.html',
  styleUrls: ['./session.component.scss']
})


export class SessionComponent{
  private selectedDuration: number = 0;
  private _url: string = '/api/session';

  Submit(dat){
    console.warn(dat)
    this.http.post(this._url, dat)
      .subscribe((res)=>{console.warn(res)

    })
      
  }
  
        constructor(private http: HttpClient) {}
      
}
