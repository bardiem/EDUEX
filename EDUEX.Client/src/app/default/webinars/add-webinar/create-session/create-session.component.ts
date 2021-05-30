import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ISession } from 'src/app/models/ISession';

@Component({
  selector: 'app-create-session',
  templateUrl: './create-session.component.html',
  styleUrls: ['./create-session.component.scss']
})
export class CreateSessionComponent implements OnInit {
  private selectedDuration = 0;
  private sessions: ISession[] = [];

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  submit(form: NgForm){
    let session: ISession = {
      id: form.value.id,
      topic: form.value.topic,
      endDate: new Date(),
      link: form.value.link,
      startDate: form.value.startDate
    };

    session.endDate = new Date(form.value.startDate);
    session.endDate.setMinutes(session.endDate.getMinutes() + form.value.duration)
    this.sessions.push(session);
    form.resetForm();
  }

}
