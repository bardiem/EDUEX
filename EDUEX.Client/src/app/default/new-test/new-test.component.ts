import { Component, OnInit } from '@angular/core';
import { NewTestService } from './value.service';

@Component({
  selector: 'app-new-test',
  templateUrl: './new-test.component.html',
  styleUrls: ['./new-test.component.scss']
})
export class NewTestComponent implements OnInit {

  constructor(private valueService: NewTestService) { }

  
  good: string[];

  ngOnInit() {
    this.valueService.get().subscribe(result =>{
       this.good = result
      });
  }
}