import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LernsiegService } from 'src/app/core/lernsieg.service';
import { SchoolDto } from 'src/models/schoolDto';
import { TeacherDto } from 'src/models/teacherDto';

@Component({
  selector: 'app-teacher',
  templateUrl: './teacher.component.html',
  styleUrls: ['./teacher.component.scss'],
})
export class TeacherComponent implements OnInit {
  filter: string;
  teachers: TeacherDto[] = [];
  @Input() school;
  
  constructor(private lernsiegService: LernsiegService,
              private router: Router) { }

  ngOnInit() {
    console.log(this.school.schoolNumber);
    this.lernsiegService.getTeachersOfSchool(this.school.schoolNumber).subscribe(x => {
      this.teachers = x;
    });
  }

  filterList(e){
    this.filter = e.target.value;
    if(this.filter.length != 0){
      this.lernsiegService.findTeachers(this.school.schoolNumber, this.filter).subscribe(x => {
        this.teachers = x;
      });
    }else{
      this.lernsiegService.getTeachersOfSchool(this.school.schoolNumber).subscribe(x => {
        this.teachers = x;
      });
    }
  }

  teacherSelected(teacherId: number): void{
    this.router.navigate(['/teacherevaluation', {id: teacherId}]);
  }

}
