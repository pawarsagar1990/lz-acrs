import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  menuHidden = true;

  constructor() { }

  ngOnInit() { }

  toggleMenu() {
    this.menuHidden = !this.menuHidden;
  }

  get username(): string | null {
    return 'username : null';
  }

}
