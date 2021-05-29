import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-navbar-profile',
  templateUrl: './navbar-profile.component.html',
  styleUrls: ['./navbar-profile.component.scss']
})
export class NavbarProfileComponent implements OnInit {

  UserFullName = "Богдан Яцишин";
  UserBalance = "120.00";
  constructor(private _userService: UserService) { }
  

  ngOnInit() {
    this._userService.getUser(1)
      .subscribe(data => {
        this.UserFullName = data.firstName + ' ' + data.lastName;
        this.UserBalance = data.balance.toString();
      });
  }

}
