import { Component, Inject } from '@angular/core';
import { Persona } from '../../interfaces/persona';
import { PersonasService } from '../../services/personas.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CommonModule } from '@angular/common';
import {MatDialogModule} from '@angular/material/dialog';
import { MatLabel } from '@angular/material/form-field';
import {MatButtonModule} from '@angular/material/button';


@Component({
  selector: 'app-detalles',
  imports: [CommonModule, MatDialogModule, MatLabel, MatButtonModule],
  templateUrl: './detalles.component.html',
  styleUrl: './detalles.component.scss'
})
export class DetallesComponent {
  persona: Persona
  id: number

    constructor(
      private personasServicio: PersonasService,
      public dialog: MatDialogRef<DetallesComponent>,
      @Inject(MAT_DIALOG_DATA) public data: number
    ) {
      this.id = data;
    } 

    async obtenerPersona() { 
      this.personasServicio.detailsPersona(this.id).subscribe({   
        next:(response) =>{        
          this.persona = response   
          },    
          error: (error)=>{       
            alert("Ha ocurrido un error al obtener los datos delservidor");     
          }    
        });     
      }

    ngOnInit(): void {    
      this.obtenerPersona();
    }
}
