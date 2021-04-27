import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SchoolDto } from 'src/models/schoolDto';
import { LernsiegService } from '../core/lernsieg.service';

@Component({
  selector: 'app-school',
  templateUrl: './school.page.html',
  styleUrls: ['./school.page.scss'],
})
export class SchoolPage implements OnInit {
  id: number;
  school: SchoolDto = {id: 0, name: 'HTBLA Grieskirchen', country: 'at',
                      schoolNumber: 0, address: '4770 Grieskirchen'}
  showSchoolEvaluation: boolean = true;
  showTeachers: boolean = false;
  segment: any;

  constructor(private activatedRoute: ActivatedRoute,
              private lernsiegService: LernsiegService,
              private router: Router) { }

  ngOnInit() {
    this.segment = "schoolevaluation"
    this.activatedRoute.paramMap.subscribe(x => {
      console.log(`school_comp: ${x.get('id')}`);
      this.id = Number(x.get('id'));
      /* this.lernsiegService.getSchool(this.id).subscribe(x => {
          this.school = x;
      }); */
    });
  }

  segmentChanged(e): void{
    console.log(e.target.value);
    if(e.target.value == 'schoolevaluation'){
      this.showSchoolEvaluation = true;
      this.showTeachers = false;
    }else if(e.target.value == 'teacher'){
      this.showTeachers = true;
      this.showSchoolEvaluation = false;
    }
  }

}
