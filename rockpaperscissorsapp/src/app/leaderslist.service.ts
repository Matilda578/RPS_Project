import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { of } from 'rxjs';
import { delay } from 'rxjs/operators';
import {LeaderboardResponse} from '../app/models/httpModels'

@Injectable({
  providedIn: 'root'
})
export class LeaderslistService {
  LeaderboardItem: LeaderboardResponse[] = [];

  constructor(private router: Router, private httpClient: HttpClient) { }

  leaderboard(){

  let request = this.httpClient.get<LeaderboardResponse[]>("https://my-json-server.typicode.com/kmalikkhil/json/Leaderboard",

  {});
  request.subscribe((response) => {

    this.LeaderboardItem = response;
    this.router.navigateByUrl('/LeaderBoard');
  });
}
}
