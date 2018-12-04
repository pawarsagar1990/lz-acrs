import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';

const appRoutes: Routes = [
  {
    path: '', pathMatch: 'full', redirectTo: 'login'
  },
  {
    path: 'login', component: LoginComponent
  },
  {
    path: 'dashboard',
    children: [
      {
        path: '',
        component: DashboardComponent
      }]
  },
  {
    path: '**', redirectTo: 'login'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes, {
    enableTracing: true, // <-- debugging purposes only
  })],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
