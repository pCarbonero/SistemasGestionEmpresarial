import { Component } from '@angular/core';
import {MatFormFieldModule} from '@angular/material/form-field';
import { MatCardModule } from '@angular/material/card'; 
import { MatInputModule } from '@angular/material/input';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { NgIf } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';

@Component({
  selector: 'app-formulario-angular-material',
  imports: [MatFormFieldModule, MatCardModule, MatInputModule, ReactiveFormsModule, MatButtonModule, NgIf],
  templateUrl: './formulario-angular-material.component.html',
  styleUrl: './formulario-angular-material.component.css'
})
export class FormularioAngularMaterialComponent {
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