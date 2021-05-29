import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TestComponent } from './test/test.component';
import { IndexComponent } from './index/index.component';
import { AddWebinarComponent } from './add-webinar/add-webinar.component';
import { RegisterComponent } from './register/register.component';
import { AuthGuard } from '../guards/auth.guard';
import { WebinarsComponent } from './webinars/webinars.component';

export const router: Routes = [
    { path: '', component : IndexComponent },
    { path: 'register', component: RegisterComponent},
    { path: 'test', component : TestComponent, canActivate: [AuthGuard]},
    { path: 'add-webinar', component: AddWebinarComponent},
    { path: 'webinars', component: WebinarsComponent}
];


export const routes: ModuleWithProviders = RouterModule.forChild(router);