import { Component, OnInit } from '@angular/core';
import { PersonasService } from '../../services/personas.service';
import { Persona } from '../../interfaces/persona';
import { NgFor, CommonModule } from '@angular/common';
import {MatTableModule} from '@angular/material/table';
import { MatHeaderRowDef } from '@angular/material/table';
import { MatRowDef } from '@angular/material/table';

@Component({
  selector: 'app-tabla-personas',
  imports: [/*NgFor,*/ CommonModule, MatTableModule, MatHeaderRowDef, MatRowDef],
  templateUrl: './tabla-personas.component.html',
  styleUrl: './tabla-personas.component.scss'
})


export class TablaPersonasComponent implements OnInit{
  listadoPersonas: Persona[]; 
  displayedColumns: string[] = ['id', 'nombre', 'apellidos', 'fechaNacimiento'];

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

  ngOnInit(): void {    
    this.obtenerPersonas(); 
  }
}
