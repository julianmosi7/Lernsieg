import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { TeacherevaluationPage } from './teacherevaluation.page';

const routes: Routes = [
  {
    path: '',
    component: TeacherevaluationPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class TeacherevaluationPageRoutingModule {}
