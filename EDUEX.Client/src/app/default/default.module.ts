import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TestComponent } from './test/test.component';
import { routes } from './default.router';
import { IndexComponent } from './index/index.component';
import { NewTestComponent } from './new-test/new-test.component';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { RegisterComponent } from './register/register.component';
import { AuthGuard } from './guards/auth.guard';

@NgModule({
  declarations: [
    IndexComponent,
    TestComponent,
    NewTestComponent,
    RegisterComponent
    ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    routes
  ],
  providers: [
    AuthGuard
  ]
})
export class DefaultModule { }
