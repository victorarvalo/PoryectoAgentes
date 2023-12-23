import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgentBComponent } from './agent-b.component';

describe('AgentBComponent', () => {
  let component: AgentBComponent;
  let fixture: ComponentFixture<AgentBComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AgentBComponent]
    });
    fixture = TestBed.createComponent(AgentBComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
