import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { routes } from './app.router';
import { JwtIntercentorService } from './services/jwt-intercentor.service';
import { FormsModule } from '@angular/forms';
import { NavbarProfileComponent } from './default/navbar/navbar-profile/navbar-profile.component';
import { NavbarButtonsComponent } from './default/navbar/navbar-buttons/navbar-buttons.component';
import { NavbarComponent } from './default/navbar/navbar.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AddWebinarComponent } from './default/add-webinar/add-webinar.component';
import { CreateSessionComponent } from './default/add-webinar/create-session/create-session.component';




@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    NavbarButtonsComponent,
    NavbarProfileComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    routes
  ],
  providers: [{
    provide: HTTP_INTERCEPTORS,
    useClass: JwtIntercentorService,
    multi: true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
