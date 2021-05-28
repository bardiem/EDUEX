import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TestComponent } from './test/test.component';
import { routes } from './default.router';
import { IndexComponent } from './index/index.component';
import { NewTestComponent } from './new-test/new-test.component';
import { FormsModule} from '@angular/forms';

@NgModule({
  declarations: [
    IndexComponent,
    TestComponent,
    NewTestComponent,
    FormsModule
    ],
  imports: [
    CommonModule,
    routes
  ]
})
export class DefaultModule { }
