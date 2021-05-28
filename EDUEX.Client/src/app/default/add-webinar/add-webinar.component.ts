import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-webinar',
  templateUrl: './add-webinar.component.html',
  styleUrls: ['./add-webinar.component.scss']
})
export class AddWebinarComponent implements OnInit {

  private _url: string = '/api/webinar';
  selectedDifficulty: number = 0;
  lev=1;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    
  }

  onSubmit(data){
    console.warn(data)
    this.http.post(this._url, data)
      .subscribe((result)=>{console.warn(result)
      
    })
  }
  
}
