import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TestComponent } from './test/test.component';
import { routes } from './default.router';
import { IndexComponent } from './index/index.component';
import { NewTestComponent } from './new-test/new-test.component';
import { FormsModule} from '@angular/forms';
import { RegisterComponent } from './register/register.component';

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
    routes
  ]
})
export class DefaultModule { }
