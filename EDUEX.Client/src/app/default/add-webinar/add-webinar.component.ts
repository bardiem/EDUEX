import { Component, OnInit } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Component({
  selector: 'app-add-webinar',
  templateUrl: './add-webinar.component.html',
  styleUrls: ['./add-webinar.component.scss']
})

@Injectable({providedIn : "root"})
export class AddWebinarComponent {
  onSubmit(data){
    console.warn(data)
    this.http.post(this._url,data)
    .subscribe((result)=>{console.warn(result)
      
    })
  }
  lev=1;
    constructor(private http: HttpClient) {}
    private _url: string = '/api/webinar'; 
}



