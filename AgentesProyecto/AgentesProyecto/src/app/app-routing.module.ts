import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { AgentAComponent } from './component/agent-a/agent-a.component';
import { AgentBComponent } from './component/agent-b/agent-b.component';
import { AgentCComponent } from './component/agent-c/agent-c.component';

const routes: Routes=[
  {path:'AgenteA', component:AgentAComponent},
  {path:'AgenteB', component:AgentBComponent},
  {path:'AgenteC', component:AgentCComponent}
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
