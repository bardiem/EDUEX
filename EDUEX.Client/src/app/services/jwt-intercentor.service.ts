import { HttpInterceptor } from '@angular/common/http';
import { Injectable, Injector } from '@angular/core';
import { AuthenticationService } from './authentication.service';

@Injectable({
  providedIn: 'root'
})
export class JwtIntercentorService implements HttpInterceptor {

  constructor(private injector: Injector) { }

  intercept(req, next){
    let authService = this.injector.get(AuthenticationService);
    let tokenizedRequest = req.clone({
      setHeaders: {
        Authorization: "Bearer " + authService.getToken()
      }
    })
    return next.handle(tokenizedRequest);
  }
}
