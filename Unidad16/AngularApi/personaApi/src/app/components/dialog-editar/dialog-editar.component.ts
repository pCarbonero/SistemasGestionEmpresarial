import { Component, Inject } from '@angular/core';
import {MatDialogModule} from '@angular/material/dialog';
import { Persona } from '../../interfaces/persona';
import { PersonasService } from '../../services/personas.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { FormsModule } from '@angular/forms';
import { MatFormField } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-dialog-editar',
  imports: [MatDialogModule, FormsModule, MatFormField, MatInputModule, MatButtonModule, CommonModule],
  templateUrl: './dialog-editar.component.html',
  styleUrl: './dialog-editar.component.scss'
})
export class DialogEditarComponent {
  persona: Persona

  constructor(
    private personasServicio: PersonasService,
    public dialog: MatDialogRef<DialogEditarComponent>,
    @Inject(MAT_DIALOG_DATA) public data: Persona
  ) {
    this.persona = data;
  }

  guardar(): void {
    this.dialog.close(this.persona);
  }

  async guardarPersona() { 
    this.personasServicio.updatePersona(this.persona).subscribe({   
      next:(response) =>{        
        alert("Se ha actualizado correctamente");
        this.dialog.close();       
        },    
        error: (error)=>{       
          alert("Ha ocurrido un error al obtener los datos delservidor");     
        }    
      });     
    }

}
