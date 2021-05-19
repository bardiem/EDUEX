import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TestComponent } from './test/test.component';
import { IndexComponent } from './index/index.component';
import { NewTestComponent } from './new-test/new-test.component';


export const router: Routes = [
    { path: '', component : TestComponent },
    { path: 'test', component : IndexComponent  },
    { path: 'newTest', component: NewTestComponent}
]

export const routes: ModuleWithProviders = RouterModule.forChild(router);