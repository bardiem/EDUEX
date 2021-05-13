import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TestComponent } from './test/test.component';
import { routes } from './default.router';
import { IndexComponent } from './index/index.component';
import { NavbarComponent } from './navbar/navbar.component';

@NgModule({
  declarations: [
    IndexComponent,
    TestComponent,
    NavbarComponent
    ],
  imports: [
    CommonModule,
    routes
  ]
})
export class DefaultModule { }
