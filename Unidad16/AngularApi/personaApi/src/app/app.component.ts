import { Component } from '@angular/core';
import { RouterOutlet, RouterLink, RouterLinkActive } from '@angular/router';
import { TablaPersonasComponent } from './components/tabla-personas/tabla-personas.component';

@Component({
  selector: 'app-root',
  imports: [[RouterOutlet, RouterLink, RouterLinkActive]],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'personaApi';
}
