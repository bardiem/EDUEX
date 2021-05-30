import { Component, OnInit } from '@angular/core';
import { IWebinar } from 'src/app/models/IWebinar';
import { SharedDataService } from 'src/app/services/share-data.service';
import { WebinarService } from 'src/app/services/webinar.service';

@Component({
  selector: 'app-webinars',
  templateUrl: './webinars.component.html',
  styleUrls: ['./webinars.component.scss']
})
export class WebinarsComponent implements OnInit {
  subjects: string[] = [];
  selectedSubject: string = "";
  orderType: string = "0";
  webinars: IWebinar[] = [];

  constructor(private webinarService: WebinarService, private sharedService: SharedDataService) { }

  ngOnInit() {
    this.sharedService.emitChange('Вебінари');

    this.webinarService.getSubjects()
      .subscribe(data => this.subjects = data);

    this.loadWebinars();
  }

  loadWebinars(){
    this.webinarService.getWebinars(this.selectedSubject, parseInt(this.orderType))
      .subscribe(data=>{
        this.webinars = data;
      })
  }
  
  applyFilter(){
    this.loadWebinars();
  }

}
