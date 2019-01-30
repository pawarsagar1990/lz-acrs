import { DashboardComponent } from './dashboard.component';
import { ConsultationDetailComponent } from './consultation-details/consultation-details.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { DataTableModule } from 'angular-6-datatable';
import { SharedModule } from 'src/app/shared/shared.module';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    FormsModule,
    HttpModule,
    NgbModule,
    ReactiveFormsModule,
    DataTableModule,
    SharedModule
  ],
  declarations: [
    DashboardComponent,
    ConsultationDetailComponent,
  ],
  exports: [
    DashboardComponent,
    ConsultationDetailComponent,
  ]
})
export class DashboardModule { }
