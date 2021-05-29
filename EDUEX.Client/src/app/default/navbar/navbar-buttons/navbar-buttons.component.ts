import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navbar-buttons',
  templateUrl: './navbar-buttons.component.html',
  styleUrls: ['./navbar-buttons.component.scss']
})
export class NavbarButtonsComponent implements OnInit {
  Email:string = "s";
  Password:string = "";

  constructor() { }

  logIn(){
    alert(this.Email);
  }

  ngOnInit() {
  }

}
