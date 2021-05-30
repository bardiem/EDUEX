import { Component, Input, OnInit } from '@angular/core';
import { IWebinar } from 'src/app/models/IWebinar';

@Component({
  selector: 'app-webinars-item',
  templateUrl: './webinars-item.component.html',
  styleUrls: ['./webinars-item.component.scss']
})
export class WebinarsItemComponent implements OnInit {
  @Input() webinar : IWebinar;

  difficulty;

  constructor() { }

  ngOnInit() {
    if(this.webinar.level==1)
      this.difficulty = "Легкий";
    else if(this.webinar.level==2)
      this.difficulty = "Середній";
    else if(this.webinar.level==3)
      this.difficulty = "Важкий";
  }

}
