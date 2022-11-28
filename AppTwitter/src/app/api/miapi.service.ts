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
  GetTweets(idUser): Observable<any> {
    return this.http
      .get(
        'https://localhost:7068/api/TweetsControllers/' + idUser,
      )
      .pipe(tap((_) => console.log(_.tweets)));
  }

  GetProfile(): Observable<any> {
    return this.http
      .get(
        'https://localhost:7068/api/Usuario/4',
      )
      .pipe(tap((_) => console.log(_.profile)));
  }

  PostTweet(): Observable<any> {
    return this.http
      .post(
        'https://localhost:7097/api/TweetsControllers/',
        {
          "id": 101,
          "iD_Usuario": 4,
          "texto": "adasdasdasasdasd",
          "fecha": "2022-11-02T04:56:50.760Z",
          "retweets": 15,
          "likes": 10,
          "respuestas": 111
        }
      )
      .pipe(tap((_) => console.log(_.profile)));
  }
  Login(user, password): Observable<any> {
    return this.http
      .post('https://localhost:7068/api/Usuario/login?nick=' + user + '&pass=' + password, {})
  }

  Registro(nombre, apellido, usuario, correo, pass): Observable<any> {
    var min = Math.ceil(1);
    var max = Math.floor(100000);
    var Seguidos = Math.floor(Math.random() * (max - min) + min);
    var Seguidores = Math.floor(Math.random() * (max - min) + min);
    console.log(Seguidos, Seguidores);
    return this.http
      .post('https://localhost:7068/api/Usuario', {

        "nick": usuario,
        "password": pass,
        "nombre": nombre,
        "apellido": apellido,
        "correo": correo,
        "urlImage": "string",
        "fechaIngreso": "2021-11-02T04:56:50.760Z",
        "cantidadSeguidos": Seguidos.toFixed(0),
        "cantidadSeguidores": Seguidores.toFixed(0),
      })
  }

}
