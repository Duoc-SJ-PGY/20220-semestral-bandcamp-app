import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-catalogo',
  templateUrl: './catalogo.page.html',
  styleUrls: ['./catalogo.page.scss'],
})
export class CatalogoPage implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
    
  }
  //goToBestsellings(){
   // this.router.navigate(['tablinks/tablinks/bestsellings']);
   // console.log("goToBestsellings");
  //}

}
