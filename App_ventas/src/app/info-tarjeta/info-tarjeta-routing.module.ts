import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { InfoTarjetaPage } from './info-tarjeta.page';

const routes: Routes = [
  {
    path: '',
    component: InfoTarjetaPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class InfoTarjetaPageRoutingModule {}
