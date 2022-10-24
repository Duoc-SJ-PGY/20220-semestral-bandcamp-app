import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class MiapiService {
  constructor(private http: HttpClient) {}

  // GetTweets() {
  //   return this.http.get<Array<String>>(
  //     'https://devdactic.fra1.digitaloceanspaces.com/twitter-ui/tweets.json'
  //   );
  // }
  GetTweets(): Observable<any> {
    return this.http
      .get(
        'https://devdactic.fra1.digitaloceanspaces.com/twitter-ui/tweets.json'
      )
      .pipe(tap((_) => console.log(_.tweets)));
  }
}
