import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GamestartComponent } from './gamestart/gamestart.component' ;
import { LeaderboardComponent } from './leaderboard/leaderboard.component';
import { ResultscreenComponent } from './resultscreen/resultscreen.component';

const routes: Routes = [
  { path: "gamestart", component: GamestartComponent },
  { path: "GetResult", component: ResultscreenComponent },
  {path: "LeaderBoard", component: LeaderboardComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
