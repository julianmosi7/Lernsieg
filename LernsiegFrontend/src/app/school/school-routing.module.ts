import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SchoolPage } from './school.page';
import { SchoolevaluationComponent } from './schoolevaluation/schoolevaluation.component';
import { TeacherComponent } from './teacher/teacher.component';

const routes: Routes = [
  {
    path: '',
    component: SchoolPage,
    children: [
      { path: '', component: SchoolevaluationComponent }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class SchoolPageRoutingModule {}
