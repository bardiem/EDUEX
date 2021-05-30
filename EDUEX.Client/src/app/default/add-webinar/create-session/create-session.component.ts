import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Session } from 'inspector';
import { ISession } from 'src/app/models/ISession';

@Component({
  selector: 'app-create-session',
  templateUrl: './create-session.component.html',
  styleUrls: ['./create-session.component.scss']
})
export class CreateSessionComponent implements OnInit {
  private selectedDuration: number = 0;
  private sessions: ISession;

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  submit(form: NgForm){

    this.http.post('/api/session', form.value)
      .subscribe((res)=>{console.warn(res)
    })
  }

}
