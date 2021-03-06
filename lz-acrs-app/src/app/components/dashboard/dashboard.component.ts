import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  data: any;

  constructor(private httpService: HttpClient) { }

  ngOnInit() {
    this.httpService.get('https://vjdwzivth7.execute-api.us-west-2.amazonaws.com/Stage/consultation/505045382').subscribe(
      result => {
        this.data = result as any;	 // FILL THE ARRAY WITH DATA.
      },
      (err: HttpErrorResponse) => {
        console.log(err.message);
      }
    );
  }
}
