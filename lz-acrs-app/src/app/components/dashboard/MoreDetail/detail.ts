import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders,HttpErrorResponse } from '@angular/common/http';
import { Bird } from '../Bird';

@Component({
  selector: 'app-MoreDetail',
  templateUrl: './detail.html'
  //styleUrls: ['./detail.scss']
})
export class MoreDetailComponent implements OnInit {
  data: any;

  constructor(private httpService: HttpClient) { }

  ngOnInit() {
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

  /*getHeroes(): void {
    this.heroService.getHeroes()
    .subscribe(heroes => this.heroes = heroes);
  }*/
}