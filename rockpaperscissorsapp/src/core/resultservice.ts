import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { of } from 'rxjs';
import { delay } from 'rxjs/operators';

import {Result, PlayerChoice} from "../app/models/httpModels";


@Injectable({
  providedIn: 'root'
})
export class resultService {

  private _selection?: string;

  get selection(){
    return this._selection;
  }

  constructor(private router: Router, private client: HttpClient) { }


  commitSelection(value: string) {
    this.client.post<string>("http://localhost:5001/results", value,)
      .subscribe((response) => {
        console.log(response)
        this._selection = response;
        this.router.navigateByUrl("/results");



        // this._selection = response.;
        // this.router.navigateByUrl("/display");
    });
  }

}

