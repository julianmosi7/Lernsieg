import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { SchoolPageRoutingModule } from './school-routing.module';

import { SchoolPage } from './school.page';
import { SchoolevaluationComponent } from './schoolevaluation/schoolevaluation.component';
import { TeacherComponent } from './teacher/teacher.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    SchoolPageRoutingModule
  ],
  declarations: [SchoolPage, SchoolevaluationComponent, TeacherComponent]
})
export class SchoolPageModule {}
