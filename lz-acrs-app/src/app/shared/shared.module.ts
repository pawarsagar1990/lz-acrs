import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { LayoutComponent } from './layout/layout.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    FormsModule,
    HttpModule,
    NgbModule,
    ReactiveFormsModule,
  ],
  declarations: [
    LayoutComponent,
    HeaderComponent,
    FooterComponent
  ],
  exports: [
    LayoutComponent
  ]
})
export class SharedModule { }
