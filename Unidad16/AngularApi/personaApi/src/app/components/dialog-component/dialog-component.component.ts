import { Component, Inject } from '@angular/core';
import {MatDialogModule} from '@angular/material/dialog';
import { Persona } from '../../interfaces/persona';
import { PersonasService } from '../../services/personas.service';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { FormsModule } from '@angular/forms';
import { MatFormField } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';

@Component({
  selector: 'app-dialog-component',
  imports: [MatDialogModule, FormsModule, MatFormField, MatInputModule, MatButtonModule],
  templateUrl: './dialog-component.component.html',
  styleUrl: './dialog-component.component.scss'
})
export class DialogComponentComponent {
 // aqui que pongo
  persona: Persona = {nombre: '', apellidos: '', telefono: '', direccion: '', foto: '', fechaNacimiento: new Date(2000, 0, 2), idDepartamento: 0};

  constructor(
    private personasServicio: PersonasService,
    public dialogRef: MatDialogRef<DialogComponentComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {}

  guardar(): void {
    this.dialogRef.close(this.persona);
  }

  async guardarPersona() { 
    this.personasServicio.addPersona(this.persona).subscribe({   
      next:(response) =>{        
        alert("Se ha guardado correctamente");
        this.dialogRef.close();       
        },    
        error: (error)=>{       
          alert("Ha ocurrido un error");     
        }    
      });     
    }

}
