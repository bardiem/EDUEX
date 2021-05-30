import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TestComponent } from './test/test.component';
import { IndexComponent } from './index/index.component';
import { AddWebinarComponent } from './webinars/add-webinar/add-webinar.component';
import { RegisterComponent } from './register/register.component';
import { AuthGuard } from '../guards/auth.guard';
import { WebinarsComponent } from './webinars/webinars.component';
import { WebinarDetailsComponent } from './webinars/webinar-details/webinar-details.component';
import { UserProfileComponent } from './user-profile/user-profile.component';

export const router: Routes = [
    { path: '', component : IndexComponent },
    { path: 'register', component: RegisterComponent},
    { path: 'test', component : TestComponent, canActivate: [AuthGuard]},
    { path: 'webinar/add', component: AddWebinarComponent},
    { path: 'webinars', component: WebinarsComponent},
    { path: 'webinar/details', component: WebinarDetailsComponent},
    { path: 'user-profile', component: UserProfileComponent}
];


export const routes: ModuleWithProviders = RouterModule.forChild(router);