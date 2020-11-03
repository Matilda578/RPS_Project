import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-gamestart',
  templateUrl: './gamestart.component.html',
  styleUrls: ['./gamestart.component.css']
})
export class GamestartComponent implements OnInit {






  constructor() { }

  ngOnInit(): void {
  }

  SelectOption(option: 'Rock' | 'Paper' | 'Scissors'){
    console.log(option)

  }

}
