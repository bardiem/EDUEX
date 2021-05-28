import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TestComponent } from './test/test.component';
import { routes } from './default.router';
import { IndexComponent } from './index/index.component';
import { AddWebinarComponent } from './add-webinar/add-webinar.component';
import { CreateSessionComponent } from './add-webinar/create-session/create-session.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    IndexComponent,
    TestComponent,
    AddWebinarComponent,
    CreateSessionComponent
    ],
  imports: [
    CommonModule,
    FormsModule,
    HttpClientModule,
    routes
  ]
})
export class DefaultModule { }
