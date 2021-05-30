import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
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
    { path: 'webinar/add', component: AddWebinarComponent, canActivate: [AuthGuard]},
    { path: 'webinars', component: WebinarsComponent, canActivate: [AuthGuard]},
    { path: 'webinar/details/:id', component: WebinarDetailsComponent, canActivate: [AuthGuard]},
    { path: 'user-profile', component: UserProfileComponent, canActivate: [AuthGuard]}
];


export const routes: ModuleWithProviders = RouterModule.forChild(router);