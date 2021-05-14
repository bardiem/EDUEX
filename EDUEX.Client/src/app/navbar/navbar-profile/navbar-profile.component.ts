import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navbar-profile',
  templateUrl: './navbar-profile.component.html',
  styleUrls: ['./navbar-profile.component.scss']
})
export class NavbarProfileComponent implements OnInit {

  UserFullName = "Богдан Яцишин";
  UserBalance = "120.00";
  constructor() { }

  ngOnInit() {
  }

}
