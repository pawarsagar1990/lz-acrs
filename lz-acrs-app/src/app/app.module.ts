import { NgModule }       from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';
import { FormsModule }    from '@angular/forms';

import { AppComponent }         from './app.component';
import { DashboardComponent }   from './dashboard/dashboard.component';
import { HeroDetailComponent }  from './hero-detail/hero-detail.component';
import { HeroesComponent }      from './heroes/heroes.component';
import {MoreDetailComponent} from './MoreDetail/detail';
import {DataTableModule} from "angular-6-datatable";

//import { MessagesComponent }    from './messages/messages.component';

import { AppRoutingModule }     from './app-routing.module';
import { HttpClientModule }    from '@angular/common/http';

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
    HeroesComponent,
    HeroDetailComponent,
    MoreDetailComponent
    //MessagesComponent
  ],
  providers: [],
  bootstrap: [ AppComponent ]
})
export class AppModule { }