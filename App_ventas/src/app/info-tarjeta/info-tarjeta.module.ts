import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { InfoTarjetaPageRoutingModule } from './info-tarjeta-routing.module';

import { InfoTarjetaPage } from './info-tarjeta.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    InfoTarjetaPageRoutingModule
  ],
  declarations: [InfoTarjetaPage]
})
export class InfoTarjetaPageModule {}
