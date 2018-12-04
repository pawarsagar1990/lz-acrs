import { AuthGuard } from './../../core/auth/auth-guard.service';
import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './dashboard.component';

const dashboardRoutes: Routes = [
  {
    path: 'dashboard',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        component: DashboardComponent
      }]
  },
];

@NgModule({
  imports: [RouterModule.forChild(dashboardRoutes)],
  exports: [
    RouterModule
  ]
})
export class DashboardRoutingModule { }
