import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IWebinarWithSessions } from 'src/app/models/IWebinarWithSessions';
import { WebinarWithSessions } from 'src/app/models/WebinarWithSessions';
import { SharedDataService } from 'src/app/services/share-data.service';
import { WebinarService } from 'src/app/services/webinar.service';

@Component({
  selector: 'app-webinar-details',
  templateUrl: './webinar-details.component.html',
  styleUrls: ['./webinar-details.component.scss']
})
export class WebinarDetailsComponent implements OnInit {

  private webinarId: number = 1;
  private difficulty: string = "";

  private webinar: IWebinarWithSessions = new WebinarWithSessions();

  constructor(
    private webinarService: WebinarService, 
    private sharedService: SharedDataService,
    private activeRoute: ActivatedRoute
    ) { }


  ngOnInit() {
    this.webinarId = parseInt(this.activeRoute.snapshot.paramMap.get('id'));
    this.sharedService.emitChange('Деталі вебінару');

    this.webinarService.getWebinarWithSessions(this.webinarId)
      .subscribe(data => { 
        this.webinar = data;
        data.description
        this.difficulty = this.getDifficultyLevel(data.level);
      });
  }

  getDifficultyLevel(int: number){
    switch(int){
      case 0:
        return "Легкий";
      case 1:
        return "Середній";
      case 2:
        return "Важкий";
    }
  }

}
