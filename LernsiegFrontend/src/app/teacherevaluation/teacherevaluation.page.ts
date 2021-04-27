import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { TeacherDto } from 'src/models/teacherDto';
import { LernsiegService } from '../core/lernsieg.service';

@Component({
  selector: 'app-teacherevaluation',
  templateUrl: './teacherevaluation.page.html',
  styleUrls: ['./teacherevaluation.page.scss'],
})
export class TeacherevaluationPage implements OnInit {
  id: number;
  teacher: TeacherDto = {id: 0, name: "Julian", title: "Ing"};

  constructor(private activatedRoute: ActivatedRoute,
              private lernsiegService: LernsiegService,
              private router: Router) { }

  ngOnInit() {
    this.activatedRoute.paramMap.subscribe(x => {
      this.id = Number(x.get('id'));
    });
  }

  loadEvaluation(e): void {
    this.router.navigate(['/teacherevaluate', {teacher: JSON.stringify(this.teacher)}]);
  }

}
