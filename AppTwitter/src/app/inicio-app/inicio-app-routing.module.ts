import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { InicioAppPage } from './inicio-app.page';

const routes: Routes = [
  {
    path: '',
    component: InicioAppPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class InicioAppPageRoutingModule {}
