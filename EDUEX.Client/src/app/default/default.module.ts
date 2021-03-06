import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TestComponent } from './test/test.component';
import { routes } from './default.router';
import { IndexComponent } from './index/index.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule} from '@angular/forms';
import { RegisterComponent } from './register/register.component';
import { AuthGuard } from '../guards/auth.guard';
import { AddWebinarComponent } from './webinars/add-webinar/add-webinar.component';
import { CreateSessionComponent } from './webinars/add-webinar/create-session/create-session.component';
import { WebinarsComponent } from './webinars/webinars.component';
import { WebinarsItemComponent } from './webinars/webinars-item/webinars-item.component';
import { WebinarDetailsComponent } from './webinars/webinar-details/webinar-details.component';
import { UserProfileComponent } from './user-profile/user-profile.component';

@NgModule({
  declarations: [
    IndexComponent,
    TestComponent,
    RegisterComponent,
    AddWebinarComponent,
    CreateSessionComponent,
    WebinarsComponent,
    WebinarsItemComponent,
    WebinarDetailsComponent,
    UserProfileComponent
    ],
  imports: [
    CommonModule,
    FormsModule,
    HttpClientModule,
    routes
  ],
  providers: [
    AuthGuard
  ]
})
export class DefaultModule { }
