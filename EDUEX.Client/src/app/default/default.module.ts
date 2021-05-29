import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TestComponent } from './test/test.component';
import { routes } from './default.router';
import { IndexComponent } from './index/index.component';
import { AddWebinarComponent } from './add-webinar/add-webinar.component';
import { CreateSessionComponent } from './add-webinar/create-session/create-session.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NewTestComponent } from './new-test/new-test.component';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { RegisterComponent } from './register/register.component';
import { AuthGuard } from './guards/auth.guard';

@NgModule({
  declarations: [
    IndexComponent,
    TestComponent,
    RegisterComponent
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
