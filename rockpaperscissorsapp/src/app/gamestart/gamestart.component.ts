import { Component, OnInit } from '@angular/core';
import { resultService } from "../../core/resultservice";

@Component({
  selector: 'app-gamestart',
  templateUrl: './gamestart.component.html',
  styleUrls: ['./gamestart.component.css']
})
export class GamestartComponent implements OnInit {






  constructor(private resultservice: resultService) { }

  ngOnInit(): void {
  }

  SelectOption(option: 'Rock' | 'Paper' | 'Scissors'){

    this.resultservice.commitSelection(option);

    console.log(option)

  }

}
