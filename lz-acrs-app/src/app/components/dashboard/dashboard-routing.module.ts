import { ConsultationDetailComponent } from './consultation-details/consultation-details.component';
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
  {
    path: 'detail',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        component: ConsultationDetailComponent
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
