import { Component } from '@angular/core';
import { MiapiService } from '../api/miapi.service';

@Component({
  selector: 'app-tabs',
  templateUrl: 'tabs.page.html',
  styleUrls: ['tabs.page.scss']
})
export class TabsPage {
  public profile = [];

  constructor(private api: MiapiService) {}
  ngOnInit() {
   this.api.GetProfile().subscribe((data) => (this.profile = data));
  }
}
