import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private _http: HttpClient, private router: Router) {  }

  authenticate(creadentials){
    return this._http.post('/api/auth', creadentials);
  }

  loggedIn(){
    return !!localStorage.getItem("jwt");
  }

  logOutUser(){
    localStorage.removeItem("jwt");
    this.router.navigate(['/']);
  }

  getToken(){
    return localStorage.getItem("jwt");
  }
}
