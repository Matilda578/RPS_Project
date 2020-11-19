export interface PlayerChoice {
  playerSelection: string;
}

export interface ComputerSelection {
  computerSelection: string;
}

export interface Result {

  resultofGame: string;

  cPUResultofGame: number;
}


export interface LeaderboardResponse {

  username: string,
  winRatio: number,
  turnPlayed: number
}
