import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-consultation-detail',
  templateUrl: './consultation-details.component.html',
  styleUrls: ['./consultation-details.component.css']
})
export class ConsultationDetailComponent implements OnInit {
  data: any;
  id: any;
  consultation: {};

  constructor(private httpService: HttpClient, private route: ActivatedRoute) {
    this.route.params.subscribe(params => {
      console.log(params);
      if (params['id']) {
        this.id = params['id'];
      }
    });

    this.httpService.get('./assets/ConsultationData.json').subscribe(
      data => {
        this.data = data as any;	 // FILL THE ARRAY WITH DATA.
        console.log(this.data);
        this.consultation = this.data.filter(c => c.ID === this.id);
        this.consultation = this.consultation[0];
        console.log(this.consultation);
      },
      (err: HttpErrorResponse) => {
        console.log(err.message);
      }
    );
  }

  ngOnInit() {
    
  }
}
