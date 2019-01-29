import { DataTableModule } from 'angular-6-datatable';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { MoreDetailComponent } from './components/dashboard/MoreDetail/detail';

@NgModule({
  imports: [
    BrowserModule,
    FormsModule,
    DataTableModule,
    HttpClientModule,
    AppRoutingModule
  ],
  declarations: [
    AppComponent,
    DashboardComponent,
    MoreDetailComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }