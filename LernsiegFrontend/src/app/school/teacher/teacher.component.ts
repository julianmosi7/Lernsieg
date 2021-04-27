import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LernsiegService } from 'src/app/core/lernsieg.service';
import { TeacherDto } from 'src/models/teacherDto';

@Component({
  selector: 'app-teacher',
  templateUrl: './teacher.component.html',
  styleUrls: ['./teacher.component.scss'],
})
export class TeacherComponent implements OnInit {
  schoolId: number;
  filter: string;
  teachers: TeacherDto[] = [{id: 0, name: 'Julian', title: 'Ing'}];
  
  constructor(private lernsiegService: LernsiegService,
              private router: Router) { }

  ngOnInit() {
    
  }

  filterList($event){
    
  }

  teacherSelected(id): void{
    console.log(id);
    this.router.navigate(['/teacherevaluation', {id: id}])

  }

}
