import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { HttpClientModule } from '@angular/common/http';
import { GamestartComponent } from './gamestart/gamestart.component';
import { ResultscreenComponent } from './resultscreen/resultscreen.component';


@NgModule({
  declarations: [
    AppComponent,
    GamestartComponent,
    ResultscreenComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,


  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
