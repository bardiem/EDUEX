import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { routes } from './app.router';
import { HttpClientModule } from '@angular/common/http';
import { NavbarComponent } from './navbar/navbar.component';
import { NavbarButtonsComponent } from './navbar/navbar-buttons/navbar-buttons.component';
import { NavbarProfileComponent } from './navbar/navbar-profile/navbar-profile.component';
import { FormsModule } from '@angular/forms';
import { AddWebinarComponent } from './default/add-webinar/add-webinar.component';
import { CreateSessionComponent } from './default/add-webinar/create-session/create-session.component';


@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    NavbarButtonsComponent,
    NavbarProfileComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    routes
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
