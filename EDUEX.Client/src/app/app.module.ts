import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { routes } from './app.router';
import { HttpClientModule } from '@angular/common/http';
import { NavbarComponent } from './default/navbar/navbar.component';
import { NavbarButtonsComponent } from './default/navbar/navbar-buttons/navbar-buttons.component';
import { NavbarProfileComponent } from './default/navbar/navbar-profile/navbar-profile.component';


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
    routes
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
