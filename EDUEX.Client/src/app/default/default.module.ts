import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TestComponent } from './test/test.component';
import { routes } from './default.router';
import { IndexComponent } from './index/index.component';
import { NewTestComponent } from './new-test/new-test.component';
import { WebinarDetailsComponent } from './webinar-details/webinar-details.component';
import { WebinrListComponent } from './webinar-list/webinar-list.component';
import { FormsModule } from '@angular/forms';

import { NumToDifficultyPipe } from './webinar-list/num-to-difficulty.pipe';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    IndexComponent,
    TestComponent,
    NewTestComponent,
    WebinarDetailsComponent,
    WebinrListComponent,

    NumToDifficultyPipe,
  ],
  imports: [
    CommonModule,
    FormsModule,
    routes
  ]
})
export class DefaultModule { }
