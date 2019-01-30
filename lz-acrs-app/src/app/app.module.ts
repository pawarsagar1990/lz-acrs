import { SharedModule } from 'src/app/shared/shared.module';
import { ConsultationDetailComponent } from './components/dashboard/consultation-details/consultation-details.component';
import { DataTableModule } from 'angular-6-datatable';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { DashboardModule } from './components/dashboard/dashboard.module';
import { LoginModule } from './components/login/login.module';

@NgModule({
  imports: [
    BrowserModule,
    FormsModule,
    DataTableModule,
    HttpClientModule,
    AppRoutingModule,
    DashboardModule,
    SharedModule,
    LoginModule
  ],
  declarations: [
    AppComponent,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
