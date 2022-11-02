import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { MiapiService } from '../api/miapi.service';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.page.html',
  styleUrls: ['./registro.page.scss'],
})
export class RegistroPage implements OnInit {
  formularioRegistro: FormGroup;

  constructor(private fb: FormBuilder, private api : MiapiService) { 

    this.formularioRegistro = this.fb.group({
      nombre : new FormControl(''),
      apellido : new FormControl(''),
      usuario : new FormControl(''),
      password : new FormControl(''),
      correo : new FormControl(''),
    });
  }

  ngOnInit() {
  }

  Registro() {
    console.log(this.formularioRegistro.value);
     this.api.Registro(this.formularioRegistro.value.nombre, this.formularioRegistro.value.apellido, this.formularioRegistro.value.usuario, 
      this.formularioRegistro.value.correo, this.formularioRegistro.value.password).subscribe((data) => 
     { window.location.href = '/login'; }
    );

  }
}
