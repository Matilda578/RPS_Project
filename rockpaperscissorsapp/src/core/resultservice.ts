import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { of } from 'rxjs';
import { delay } from 'rxjs/operators';

import {Result, PlayerChoice, ComputerSelection} from "../app/models/httpModels";


@Injectable({
  providedIn: 'root'
})
export class resultService {

  private _selection?: Result;

  get selection(){
    return this._selection;
  }

  constructor(private router: Router, private client: HttpClient) { }



 commitSelection(value: string) {


    let playerchoiceVariable: PlayerChoice = {playerSelection:value};
    let computerselectionVariable: ComputerSelection = {computerSelection:value}



    this.client.post<Result>("https://localhost:5001/GetResult", playerchoiceVariable)
      .subscribe((response) => {
        console.log(response)

        this._selection = response;
        this.router.navigateByUrl("/GetResult");



        // this._selection = response.;
        // this.router.navigateByUrl("/display");
    });
  }

}

