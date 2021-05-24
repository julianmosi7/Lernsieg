import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { SchoolDto } from 'src/models/schoolDto';
import { LernsiegService } from '../core/lernsieg.service';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {
  schools: SchoolDto[] = [];
  filter: string;

  constructor(private router: Router, private lernsiegService: LernsiegService) {}

  ngOnInit(): void{
    this.lernsiegService.getTopSchools("at").subscribe(x => {
      this.schools = x;
    })
  }

  filterList(e): void{
    this.filter = e.target.value;
    if(this.filter.length != 0){
      this.lernsiegService.findSchools("at", e.target.value).subscribe(x => {
        this.schools = x;
      });
    }else{
      this.lernsiegService.getTopSchools("at").subscribe(x => {
        this.schools = x;
      })
    }
    console.log(`event: ${e.target.value}`);
  }

  schoolSelected(id): void{
    this.router.navigate(['/school', {id: id}])
  }
}
