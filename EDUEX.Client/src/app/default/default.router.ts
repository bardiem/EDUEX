import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TestComponent } from './test/test.component';
import { IndexComponent } from './index/index.component';
import { NewTestComponent } from './new-test/new-test.component';
import { AddWebinarComponent } from './add-webinar/add-webinar.component';
import { RegisterComponent } from './register/register.component';
import { AuthGuard } from '../guards/auth.guard';

export const router: Routes = [
    { path: '', component : TestComponent },
    { path: 'register', component: RegisterComponent},
    { path: 'test', component : IndexComponent},
    { path: 'add-webinar', component: AddWebinarComponent},
    { path: 'newTest', component: NewTestComponent, canActivate: [AuthGuard]}
];


export const routes: ModuleWithProviders = RouterModule.forChild(router);