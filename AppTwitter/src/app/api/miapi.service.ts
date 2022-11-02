import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { from } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class MiapiService {
  constructor(private http: HttpClient) { }

  GetTweets(): Observable<any> {
    return this.http
      .get(
        'https://localhost:7097/Tweets/1'
      )
      .pipe(tap((_) => console.log(_.tweets)));
  }

  GetProfile(): Observable<any> {
    return this.http
      .get(
        'https://localhost:7097/Usuarios/1',
      )
      .pipe(tap((_) => console.log(_.profile)));
  }

  PostTweet(): Observable<any> {
    return this.http
      .post(
        'https://localhost:7097/Tweets/',
        {
          "id": 0,
          "iD_Usuario": 1,
          "texto": "adasdasdasasdasd",
          "fecha": "2022-11-02T04:56:50.760Z",
          "retweets": 0,
          "likes": 0,
          "respuestas": 0
        }
      )
      .pipe(tap((_) => console.log(_.profile)));
  }
  Login(user, password): Observable<any> {
    return this.http
      .post('https://localhost:7097/Login/?nick=' + user + '&pass=' + password, {})
  }

  Registro(nombre, apellido, usuario, correo, pass): Observable<any> {
    return this.http
      .post('https://localhost:7097/Usuarios', {

        "id": 20,
        "nick": usuario,
        "password": pass,
        "nombre": nombre,
        "apellido": apellido,
        "correo": correo,
        "urlImage": "string",
        "fechaIngreso": "2022-11-02T19:48:38.054Z",
        "cantidadSeguidos": 111,
        "cantidadSeguidores": 1111
      })
  }

}
