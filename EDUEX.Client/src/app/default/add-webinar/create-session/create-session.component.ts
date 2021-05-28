import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-create-session',
  templateUrl: './create-session.component.html',
  styleUrls: ['./create-session.component.scss']
})
export class CreateSessionComponent implements OnInit {
  private selectedDuration: number = 0;
  private _url: string = '/api/session';

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  Submit(dat){
    console.warn(dat)
    this.http.post(this._url, dat)
      .subscribe((res)=>{console.warn(res)
    })
  }

}
