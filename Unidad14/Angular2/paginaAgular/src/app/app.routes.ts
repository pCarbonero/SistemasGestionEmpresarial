import { Routes } from '@angular/router';
import { TablaPersonasComponent } from './components/tabla-personas/tabla-personas.component';
import { FormularioPersonasComponent } from './components/formulario-personas/formulario-personas.component';

export const routes: Routes = [
    { path: 'tabla', component: TablaPersonasComponent },
    {path: 'formulario', component: FormularioPersonasComponent}
];
