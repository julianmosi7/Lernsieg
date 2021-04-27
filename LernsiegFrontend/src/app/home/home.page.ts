import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { SchoolDto } from 'src/models/schoolDto';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {
  schools: SchoolDto[] = [{id: 0, name: "HTBLA Grieskirchen", country: "at", schoolNumber: 43543, address: "4710 Grieskirchen, Parzer Schulstraße 1"},
                          {id: 1, name: "HTBLA Wels", country: "at", schoolNumber: 4663, address: "4600 Wels, Blumenweg 3"},
                          {id: 2, name: "BORG Grieskirchen", country: "de", schoolNumber: 4537, address: "4710 Grieskirchen Arbeitslosenweg 3"}];
  filteredSchools: SchoolDto[] = [];
  searchList: string;
  value: string;

  constructor(private router: Router) {}

  ngOnInit(): void{
    this.filteredSchools = this.schools;
  }

  filterList(e): void{
    console.log(`event: ${e.target.value}`);
    this.value = e.target.value;
    this.filteredSchools = this.schools.filter(x => (x.name.includes(this.value)) || (x.address.includes(this.value)));
  }

  schoolSelected(id): void{
    this.router.navigate(['/school', {id: id}])
  }
}
