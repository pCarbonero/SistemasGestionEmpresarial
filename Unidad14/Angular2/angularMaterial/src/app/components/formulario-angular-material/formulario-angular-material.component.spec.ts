import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormularioAngularMaterialComponent } from './formulario-angular-material.component';

describe('FormularioAngularMaterialComponent', () => {
  let component: FormularioAngularMaterialComponent;
  let fixture: ComponentFixture<FormularioAngularMaterialComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FormularioAngularMaterialComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FormularioAngularMaterialComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
