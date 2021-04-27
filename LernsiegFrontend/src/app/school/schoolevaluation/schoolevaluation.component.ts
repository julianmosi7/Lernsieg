import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { LernsiegService } from 'src/app/core/lernsieg.service';
import { SchoolDto } from 'src/models/schoolDto';

@Component({
  selector: 'app-schoolevaluation',
  templateUrl: './schoolevaluation.component.html',
  styleUrls: ['./schoolevaluation.component.scss'],
})
export class SchoolevaluationComponent implements OnInit {
  @Input() school: SchoolDto;
  //school: SchoolDto;

  constructor(private activatedRoute: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    console.log(this.school);
  }

  loadEvaluation($event){
    this.router.navigate(['/schoolevaluate', {school: JSON.stringify(this.school)}]);
  }

}
