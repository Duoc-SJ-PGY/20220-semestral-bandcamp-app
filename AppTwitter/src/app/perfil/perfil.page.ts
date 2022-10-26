import { Component, OnInit } from '@angular/core';
import { MiapiService } from '../api/miapi.service';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.page.html',
  styleUrls: ['./perfil.page.scss'],
})
export class PerfilPage implements OnInit {
  tweets = [];

  constructor(private api: MiapiService) { }

  ngOnInit() {
    this.api.GetTweets().subscribe((data) => (this.tweets = data.tweets));
  }

}
