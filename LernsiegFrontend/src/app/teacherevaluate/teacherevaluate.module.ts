import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { TeacherevaluatePageRoutingModule } from './teacherevaluate-routing.module';

import { TeacherevaluatePage } from './teacherevaluate.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    TeacherevaluatePageRoutingModule
  ],
  declarations: [TeacherevaluatePage]
})
export class TeacherevaluatePageModule {}
