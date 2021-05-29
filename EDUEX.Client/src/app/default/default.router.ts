import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TestComponent } from './test/test.component';
import { IndexComponent } from './index/index.component';
import { NewTestComponent } from './new-test/new-test.component';
import { AddWebinarComponent } from './add-webinar/add-webinar.component';

export const router: Routes = [
    { path: '', component : TestComponent },
    { path: 'test', component : IndexComponent},
    { path: 'add-webinar', component: AddWebinarComponent},
    { path: 'newTest', component: NewTestComponent}


export const routes: ModuleWithProviders = RouterModule.forChild(router);