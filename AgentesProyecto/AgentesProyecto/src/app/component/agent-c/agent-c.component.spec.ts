import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgentCComponent } from './agent-c.component';

describe('AgentCComponent', () => {
  let component: AgentCComponent;
  let fixture: ComponentFixture<AgentCComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AgentCComponent]
    });
    fixture = TestBed.createComponent(AgentCComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
