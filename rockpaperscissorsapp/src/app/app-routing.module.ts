import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GamestartComponent } from './gamestart/gamestart.component' ;
import { ResultscreenComponent } from './resultscreen/resultscreen.component';

const routes: Routes = [
  { path: "gamestart", component: GamestartComponent },
  { path: "GetResult", component: ResultscreenComponent },



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
