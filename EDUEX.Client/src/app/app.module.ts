import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { routes } from './app.router';
import { HttpModule } from '@angular/http';
import { NavbarComponent } from './navbar/navbar.component';
import { NavbarButtonsComponent } from './navbar/navbar-buttons/navbar-buttons.component';
import { NavbarProfileComponent } from './navbar/navbar-profile/navbar-profile.component';


@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    NavbarButtonsComponent,
    NavbarProfileComponent
  ],
  imports: [
    BrowserModule,
    HttpModule,
    routes
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
