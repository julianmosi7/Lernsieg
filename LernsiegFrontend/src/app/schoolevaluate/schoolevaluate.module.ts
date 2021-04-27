import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { SchoolevaluatePageRoutingModule } from './schoolevaluate-routing.module';

import { SchoolevaluatePage } from './schoolevaluate.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    SchoolevaluatePageRoutingModule
  ],
  declarations: [SchoolevaluatePage]
})
export class SchoolevaluatePageModule {}
