import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TestComponent } from './test/test.component';
import { routes } from './default.router';
import { IndexComponent } from './index/index.component';
import { NewTestComponent } from './new-test/new-test.component';

@NgModule({
  declarations: [
    IndexComponent,
    TestComponent,
    NewTestComponent
    ],
  imports: [
    CommonModule,
    routes
  ]
})
export class DefaultModule { }
