import { Component, OnInit } from '@angular/core';
import { MiapiService } from '../api/miapi.service';

@Component({
  selector: 'app-new-tweet',
  templateUrl: './new-tweet.page.html',
  styleUrls: ['./new-tweet.page.scss'],
})
export class NewTweetPage implements OnInit {
  public profile = [];
  selectPublic = undefined;
  constructor(private api: MiapiService) { }

  handleChange(ev) {
    this.selectPublic = ev.target.value;
    console.log(this.selectPublic);
  }
  
  myFunction() {
    this.api.PostTweet().subscribe((data) => (console.log(data)));
  }

  ngOnInit() {
    this.api.GetProfile().subscribe((data) => (this.profile = data));
  }

}
