import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { BestsellingsPageRoutingModule } from './bestsellings-routing.module';

import { BestsellingsPage } from './bestsellings.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    BestsellingsPageRoutingModule
  ],
  declarations: [BestsellingsPage]
})
export class BestsellingsPageModule {}
