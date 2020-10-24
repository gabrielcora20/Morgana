import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReconhecimentoComponent } from './reconhecimento.component';

describe('ReconhecimentoComponent', () => {
  let component: ReconhecimentoComponent;
  let fixture: ComponentFixture<ReconhecimentoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReconhecimentoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReconhecimentoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
