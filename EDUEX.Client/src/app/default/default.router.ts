import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TestComponent } from './test/test.component';
import { IndexComponent } from './index/index.component';
import { NewTestComponent } from './new-test/new-test.component';
import { WebinarDetailsComponent } from './webinar-details/webinar-details.component';
import { WebinrListComponent } from './webinar-list/webinar-list.component';



export const router: Routes = [
    //{ path: '', component : TestComponent },
    { path: 'test', component: IndexComponent },
    { path: 'newTest', component: NewTestComponent },
    { path: 'webinar-details', component: WebinarDetailsComponent },
    { path: 'webinar-list', component: WebinrListComponent },
    { path: "webinar-list/webinar-details/:id", component: WebinarDetailsComponent }
]

export const routes: ModuleWithProviders = RouterModule.forChild(router);

