import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgentAComponent } from './agent-a.component';

describe('AgentAComponent', () => {
  let component: AgentAComponent;
  let fixture: ComponentFixture<AgentAComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AgentAComponent]
    });
    fixture = TestBed.createComponent(AgentAComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
