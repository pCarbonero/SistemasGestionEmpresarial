import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { PersonasService } from '../../services/personas.service';
import { Persona } from '../../interfaces/persona';
import { NgFor, CommonModule } from '@angular/common';
import {MatTableModule} from '@angular/material/table';
import { MatHeaderRowDef } from '@angular/material/table';
import { MatRowDef } from '@angular/material/table';
import {MatButtonModule} from '@angular/material/button';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import { MatDialog } from '@angular/material/dialog';
import { DialogComponentComponent } from '../dialog-component/dialog-component.component';
import { DialogEditarComponent } from '../dialog-editar/dialog-editar.component';
import { MatDialogModule } from '@angular/material/dialog';

@Component({
  selector: 'app-tabla-personas',
  imports: [/*NgFor,*/ CommonModule, MatTableModule, MatHeaderRowDef, MatRowDef, MatButtonModule, MatSnackBarModule, MatDialogModule],
  templateUrl: './tabla-personas.component.html',
  styleUrl: './tabla-personas.component.scss'
 // encapsulation: ViewEncapsulation.None
})


export class TablaPersonasComponent implements OnInit{
  listadoPersonas: Persona[]; 
  displayedColumns: string[] = ['id', 'nombre', 'apellidos', 'fechaNacimiento', ' '];

  constructor(private personasServicio: PersonasService, public dialog: MatDialog) { }

  abrirCrearPersona(): void {
    let dialogRef = this.dialog.open(DialogComponentComponent, {
      height: '400px',
      width: '600px',
    });

    this.dialog.afterAllClosed.subscribe(() => {
      this.obtenerPersonas();
    });
  }

  abrirEditarPersona(personaEditar: Persona): void {
    // aqui le paso un objeto persona para que en el ts del componente se inicialice un objeto con las mismas propiedades
    let dialogRef = this.dialog.open(DialogEditarComponent, {
      height: '400px',
      width: '600px',
      data: personaEditar
    });
  }

  async obtenerPersonas() { 
    this.personasServicio.listadoPersonas().subscribe({   
      next:(response) =>{        
          this.listadoPersonas=response;         
        },    
        error: (error)=>{       
          alert("Ha ocurrido un error al obtener los datos delservidor");     
        }    
      });     
    }


  async deletePersona(id: number) { 
    this.personasServicio.deletePersona(id).subscribe({   
      next:(response) =>{    
        //let snackBarRef = snackBar.open('Message archived', 'Undo');
          this.obtenerPersonas();         
        },    
        error: (error)=>{       
          alert("Ha ocurrido un error al obtener los datos delservidor");     
        }    
      });     
    }

  ngOnInit(): void {    
    this.obtenerPersonas(); 
  }
}
