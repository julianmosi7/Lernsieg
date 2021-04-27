import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SchoolevaluatePage } from './schoolevaluate.page';

const routes: Routes = [
  {
    path: '',
    component: SchoolevaluatePage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class SchoolevaluatePageRoutingModule {}
