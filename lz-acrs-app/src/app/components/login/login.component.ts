import { Component, OnInit, Inject } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  model: any = {};
  loading = false;

  constructor(public _router: Router) {
    this.model = {};
    this.model.isValid = true;
    this.model.isSessionExpired = '0';
    this.model.rememberMe = false;
    this.model.username = "";
    this.model.password = "";
  }

  ngOnInit() {
  }

  login(isValid: boolean) {
    this.navigateToHome();
  }


  navigateToHome() {
    this._router.navigate(['/dashboard']);
  }
}
