import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { MiapiService } from '../api/miapi.service';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss'],
})
export class Tab1Page implements OnInit {
  public tweets = [];
  constructor(private api: MiapiService) {}

  ngOnInit() {
    this.api.GetTweets().subscribe((data) => console.log((this.tweets = data)));
  }
}
