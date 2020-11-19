import { Component, OnInit } from '@angular/core';
import { resultService } from '../../core/resultservice';
import { Router } from '@angular/router';
import {LeaderslistService} from '../leaderslist.service';
import { from } from 'rxjs';

@Component({
  selector: 'app-leaderboard',
  templateUrl: './leaderboard.component.html',
  styleUrls: ['./leaderboard.component.css']
})
export class LeaderboardComponent implements OnInit {

  constructor(public leaderslistService:LeaderslistService) { }

  ngOnInit(): void {
    this.leaderslistService.leaderboard();
  }

}
