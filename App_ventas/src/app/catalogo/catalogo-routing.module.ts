import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CatalogoPage } from './catalogo.page';

const routes: Routes = [
  {
    path: '',
    component: CatalogoPage,
    children: [
        {
            path: 'bestsellings',
            loadChildren: () => import('./pages/bestsellings/bestsellings.module').then( m => m.BestsellingsPageModule)
        },
      ]
        
  },
  {
    path: 'bestsellings',
    loadChildren: () => import('./pages/bestsellings/bestsellings.module').then( m => m.BestsellingsPageModule)
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CatalogoPageRoutingModule {}
