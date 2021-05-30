import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { SessinService } from './webinar-details.service';
import { WebinrListService } from '../webinar-list/webinar-list.service';

import { IWebinar } from '../webinar-list/webinar';
import { ISessin } from './session';

@Component({
  selector: 'app-webinar',
  templateUrl: './webinar-details.component.html',
  styleUrls: ['./webinar-details.component.scss']
})
export class WebinarDetailsComponent implements OnInit {

  constructor(private sessinService: SessinService, private route: ActivatedRoute,
    private webinrListService: WebinrListService) { }


  filteredSessions;
  allSessions = [];
  webinarDetails = {} as IWebinar;
  idWebinar: any;

  ngOnInit() {
    this.sessinService.get().subscribe(result => { this.allSessions = result });
    this.idWebinar = this.route.snapshot.params['id'];

    this.getOne();
  }

  getOne() {
    this.webinrListService.getWebinarID(this.idWebinar).subscribe(data => {
      this.webinarDetails = data;

      // Сесії які відносяться до цього вебінару
      this.filteredSessions = this.allSessions.filter((el) => el.webinarId == this.idWebinar);
    })
  }
}