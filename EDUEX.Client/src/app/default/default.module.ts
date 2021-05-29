import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TestComponent } from './test/test.component';
import { routes } from './default.router';
import { IndexComponent } from './index/index.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule} from '@angular/forms';
import { RegisterComponent } from './register/register.component';
import { AuthGuard } from '../guards/auth.guard';
import { AddWebinarComponent } from './add-webinar/add-webinar.component';
import { CreateSessionComponent } from './add-webinar/create-session/create-session.component';
import { NewTestComponent } from './new-test/new-test.component';

@NgModule({
  declarations: [
    IndexComponent,
    TestComponent,
    NewTestComponent,
    RegisterComponent,
    AddWebinarComponent,
    CreateSessionComponent
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
