import { Component, OnInit } from '@angular/core';
import { Hero } from '../hero';
import {Bird} from '../bird';
import { HeroService } from '../hero.service';
import { HttpClient, HttpHeaders,HttpErrorResponse } from '@angular/common/http';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: [ './dashboard.component.scss' ]
})
export class DashboardComponent implements OnInit {
  heroes: Hero[] = [];
   data: any;

  constructor(private heroService: HeroService,
    private httpService: HttpClient) { }

  ngOnInit() {
    this.getHeroes();
    this.httpService.get('./assets/birds.json').subscribe(
      data => {
        this.data = data as any;	 // FILL THE ARRAY WITH DATA.
        //  console.log(this.arrBirds[1]);
      },
      (err: HttpErrorResponse) => {
        console.log (err.message);
      }
    );
  } 
  getHeroes(): void {
    this.heroService.getHeroes()
      .subscribe(heroes => this.heroes = heroes.slice(1, 5));
  }
}
