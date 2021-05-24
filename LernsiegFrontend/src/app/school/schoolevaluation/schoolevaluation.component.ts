import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { LernsiegService } from 'src/app/core/lernsieg.service';
import { CriteriaDto } from 'src/models/criteriaDto';
import { EvaluationDto } from 'src/models/evaluationDto';
import { SchoolDto } from 'src/models/schoolDto';

@Component({
  selector: 'app-schoolevaluation',
  templateUrl: './schoolevaluation.component.html',
  styleUrls: ['./schoolevaluation.component.scss'],
})
export class SchoolevaluationComponent implements OnInit {
  @Input() school: SchoolDto;
  criterias: CriteriaDto[] = [];
  evaluations: EvaluationDto[] = [];

  constructor(private activatedRoute: ActivatedRoute, private router: Router,
              private lernsiegService: LernsiegService) { }

  ngOnInit() {
    this.lernsiegService.getCriterias(1).subscribe(x => {
      this.criterias = x;
      console.log(this.criterias);
    });
    this.lernsiegService.getEvaluations(this.school.schoolNumber, 1).subscribe(x => {
      this.evaluations = x;
      console.log(this.evaluations);
    })
    console.log(this.school);
    
  }

  loadEvaluation($event){
    this.router.navigate(['/schoolevaluate', {school: JSON.stringify(this.school)}]);
  }
}
