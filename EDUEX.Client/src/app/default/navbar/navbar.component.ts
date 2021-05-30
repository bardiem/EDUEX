import { AfterViewInit, Component, OnInit } from '@angular/core';
import { AuthenticationService } from 'src/app/services/authentication.service';
import { SharedDataService } from 'src/app/services/share-data.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit, AfterViewInit{

  PageName;

  constructor(private authService: AuthenticationService, private sharedService: SharedDataService) { }
  ngAfterViewInit() {
    this.sharedService.changeEmitted$.subscribe(
      text => {
          this.PageName = text;
      });
  }

  ngOnInit() {
    
  }


}
