import { LoginComponent } from './login.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { DataTableModule } from 'angular-6-datatable';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from 'src/app/app-routing.module';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        DataTableModule,
        HttpClientModule,
        AppRoutingModule,
        SharedModule
    ],
    declarations: [
        LoginComponent,
    ],
    exports: [
        LoginComponent
    ]
  providers: [],
})
export class LoginModule { }
