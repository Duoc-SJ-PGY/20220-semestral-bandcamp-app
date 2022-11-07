import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { MiapiService } from '../api/miapi.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {
  public profile = [];
  formularioLogin: FormGroup;

  constructor(private fb: FormBuilder, private api : MiapiService) { 

    this.formularioLogin = this.fb.group({
      usuario: new FormControl(''),
      password: new FormControl(''),
    });
  }

  ngOnInit() {
  }

    login() {
    console.log(this.formularioLogin.value);
     this.api.Login(this.formularioLogin.value.usuario, this.formularioLogin.value.password).subscribe((data) => 
     { 
      if(data != null)
     { window.location.href = '/tabs/tab1';
      this.profile = data;}
      }
    );

  }
}
