import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TestComponent } from './test/test.component';
import { IndexComponent } from './index/index.component';
import { NewTestComponent } from './new-test/new-test.component';
import { RegisterComponent } from './register/register.component';
import { AuthGuard } from './guards/auth.guard';


export const router: Routes = [
    { path: '', component : TestComponent },
    { path: 'test', component : IndexComponent  },
    { path: 'newTest', component: NewTestComponent, canActivate: [AuthGuard]},
    { path: 'register', component: RegisterComponent}
]

export const routes: ModuleWithProviders = RouterModule.forChild(router);