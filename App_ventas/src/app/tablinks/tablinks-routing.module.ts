import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { TablinksPage } from './tablinks.page';

const routes: Routes = [
  {
    path:'catalogo',
    loadChildren: () => import('../catalogo/catalogo.module').then( m => m.CatalogoPageModule)
  },
  {
    path:'inicio',
    loadChildren: () => import('../inicio/inicio.module').then( m => m.InicioPageModule)
  },
  {
    path:'perfil',
    loadChildren: () => import('../perfil/perfil.module').then( m => m.PerfilPageModule)
  },
  {
    path: '',
    redirectTo: 'inicio',
    pathMatch: 'full'
  },
    
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class TablinksPageRoutingModule {}
