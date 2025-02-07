import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { PersonasService } from '../../services/personas.service';
import { Persona } from '../../interfaces/persona';
import { NgFor, CommonModule } from '@angular/common';
import {MatTableModule} from '@angular/material/table';
import { MatHeaderRowDef } from '@angular/material/table';
import { MatRowDef } from '@angular/material/table';
import {MatButtonModule} from '@angular/material/button';
import {MatSnackBarModule} from '@angular/material/snack-bar';

@Component({
  selector: 'app-tabla-personas',
  imports: [/*NgFor,*/ CommonModule, MatTableModule, MatHeaderRowDef, MatRowDef, MatButtonModule, MatSnackBarModule],
  templateUrl: './tabla-personas.component.html',
  styleUrl: './tabla-personas.component.scss'
 // encapsulation: ViewEncapsulation.None
})


export class TablaPersonasComponent implements OnInit{
  listadoPersonas: Persona[]; 
  displayedColumns: string[] = ['id', 'nombre', 'apellidos', 'fechaNacimiento', ' '];

  constructor(private personasServicio: PersonasService) { }

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
