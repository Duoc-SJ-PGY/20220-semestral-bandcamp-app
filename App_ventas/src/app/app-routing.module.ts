import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'tablinks',
    loadChildren: () => import('./tablinks/tablinks.module').then( m => m.TablinksPageModule)
  },
  {
    path: '',
    redirectTo: 'tablinks',
    pathMatch: 'full'
  },  {
    path: 'info-tarjeta',
    loadChildren: () => import('./info-tarjeta/info-tarjeta.module').then( m => m.InfoTarjetaPageModule)
  },

];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
