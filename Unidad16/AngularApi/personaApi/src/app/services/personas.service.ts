import { inject, Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs';

import { Persona } from '../interfaces/persona';

@Injectable({
  providedIn: 'root'
})
export class PersonasService {

  urlWebAPI='https://pablocarboneroasp1.azurewebsites.net/api/personaapi';

  constructor() { }
  http=inject(HttpClient);
  listadoPersonas(): Observable<Persona[]>{

    return this.http.get<Persona[]>(this.urlWebAPI);
    
    }
}
