import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-formulario-personas',
  imports: [ReactiveFormsModule, NgIf],
  templateUrl: './formulario-personas.component.html',
  styleUrl: './formulario-personas.component.css'
})
export class FormularioPersonasComponent {
  formulario!: FormGroup
  ngOnInit() {
    this.formulario = new FormGroup({
      nombre: new FormControl('',[Validators.required]),
      apellidos: new FormControl('',[Validators.required]),
    });
  }
  constructor() { }
  saluda() {
    if (this.formulario.valid) {
      alert("Hola " + this.formulario.controls.nombre.value + " " + this.formulario.controls.apellidos.value); 
    }
  }
}
