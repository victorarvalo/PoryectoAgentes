import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { NavComponent } from './component/nav/nav.component';
import { AgentAComponent } from './component/agent-a/agent-a.component';
import { AgentBComponent } from './component/agent-b/agent-b.component';
import { AgentCComponent } from './component/agent-c/agent-c.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    AgentAComponent,
    AgentBComponent,
    AgentCComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
