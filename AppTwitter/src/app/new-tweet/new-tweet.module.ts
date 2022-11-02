import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { NewTweetPageRoutingModule } from './new-tweet-routing.module';

import { NewTweetPage } from './new-tweet.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    NewTweetPageRoutingModule
  ],
  declarations: [NewTweetPage]
})
export class NewTweetPageModule {}
