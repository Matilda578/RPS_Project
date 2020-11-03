import { Component, OnInit } from '@angular/core';
import { resultService } from '../../core/resultservice';
import { Router } from '@angular/router';


@Component({
  selector: 'app-resultscreen',
  templateUrl: './resultscreen.component.html',
  styleUrls: ['./resultscreen.component.css']
})
export class ResultscreenComponent implements OnInit {

  constructor(public resultService: resultService, private router: Router ) { }

  ngOnInit(): void {

  }

}

