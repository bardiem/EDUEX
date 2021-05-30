import { Component, OnInit } from '@angular/core';
import { SharedDataService } from 'src/app/services/share-data.service';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.scss']
})
export class IndexComponent implements OnInit {

  constructor(private sharedService: SharedDataService) { }

  ngOnInit() {
    this.sharedService.emitChange('Домашня сторінка');
  }

}
