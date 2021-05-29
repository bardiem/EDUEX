import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication.service';


@Component({
  selector: 'app-navbar-buttons',
  templateUrl: './navbar-buttons.component.html',
  styleUrls: ['./navbar-buttons.component.scss']
})
export class NavbarButtonsComponent implements OnInit {
  invalidLogin: boolean;
  isLogged: boolean = false;

  constructor(private authService: AuthenticationService, private router: Router) { }

  ngOnInit() {
  }

  logIn(form: NgForm){
    console.log(form);

    const credentials = {
      email: form.value.email,
      password: form.value.password
    };

    this.authService.authenticate(credentials)
      .subscribe(response => {
        const token = (<any>response).token;
        localStorage.setItem("jwt", token);
        form.resetForm();
        //this.router.navigate(["/"]);
        this.isLogged = true;
      },
      error => {
        this.invalidLogin = true;
        setTimeout(() => this.invalidLogin = false, 3000); 
      }
      );

  }

}
