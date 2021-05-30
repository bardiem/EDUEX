import { Component, OnInit } from '@angular/core';
import { WebinrListService } from './webinar-list.service';
import { IWebinar } from './webinar';

@Component({
  selector: 'app-webinar',
  templateUrl: './webinar-list.component.html',
  styleUrls: ['./webinar-list.component.scss']
})
export class WebinrListComponent implements OnInit {

  sortingColumn: string;
  isDesc: boolean;

  webinarList: IWebinar[];
  public cacheWebinars: IWebinar[];
  public summaries: any[];

  private addParameter: boolean = false;

  
  constructor(private webinrListService: WebinrListService) { }



  ngOnInit() {
    this.webinrListService.get().subscribe(result => {
      this.webinarList = result;
      this.cacheWebinars = this.webinarList;
    });

    this.webinrListService.get().subscribe(result => {
      this.summaries = result;
    });
  }

  filterWebinars(filterVal: any) {
    if (filterVal == "0")
      this.webinarList = this.cacheWebinars;
    else
      this.webinarList = this.cacheWebinars.filter((item) => item.subject == filterVal);
  }



  public ProductDetails: object = [];

  SortPrice() {
    //міняєм напрямок стрілки
    this.addParameter = !this.addParameter;

    if (this.isDesc) {
      let newList = this.webinarList.sort((a, b) => a.price - b.price);
      this.ProductDetails = newList;
    }
    else {
      let newList = this.webinarList.sort((a, b) => b.price - a.price);
      this.ProductDetails = newList;
    }
    this.isDesc = !this.isDesc;
  }
}