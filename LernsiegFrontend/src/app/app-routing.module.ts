import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'home',
    loadChildren: () => import('./home/home.module').then( m => m.HomePageModule)
  },
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full'
  },
  {
    path: 'school',
    loadChildren: () => import('./school/school.module').then( m => m.SchoolPageModule)
  },
  {
    path: 'schoolevaluate',
    loadChildren: () => import('./schoolevaluate/schoolevaluate.module').then( m => m.SchoolevaluatePageModule)
  },
  {
    path: 'teacherevaluate',
    loadChildren: () => import('./teacherevaluate/teacherevaluate.module').then( m => m.TeacherevaluatePageModule)
  },
  {
    path: 'teacherevaluation',
    loadChildren: () => import('./teacherevaluation/teacherevaluation.module').then( m => m.TeacherevaluationPageModule)
  },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
