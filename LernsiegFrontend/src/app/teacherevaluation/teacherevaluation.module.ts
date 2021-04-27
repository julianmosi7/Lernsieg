import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { TeacherevaluationPageRoutingModule } from './teacherevaluation-routing.module';

import { TeacherevaluationPage } from './teacherevaluation.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    TeacherevaluationPageRoutingModule
  ],
  declarations: [TeacherevaluationPage]
})
export class TeacherevaluationPageModule {}
