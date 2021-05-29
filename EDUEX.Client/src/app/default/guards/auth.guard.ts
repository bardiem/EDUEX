import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate  {

  constructor(private authService: AuthenticationService, private router: Router){

  }

  canActivate() : boolean{
    if(this.authService.loggedIn()){
      return true;
    }else{
      return false;
    }
  }
  
}
