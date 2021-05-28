import { Component, OnInit } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Component({
  selector: 'app-add-webinar',
  templateUrl: './add-webinar.component.html',
  styleUrls: ['./add-webinar.component.scss']
})

export class AddWebinarComponent {
  private _url: string = '/api/webinar'; 

  selectedDifficulty: number = 0;

  onSubmit(data){
    console.warn(data)
    this.http.post(this._url, data)
      .subscribe((result)=>{console.warn(result)
      
    })
  }
  lev=1;
    constructor(private http: HttpClient) {}
    
}



