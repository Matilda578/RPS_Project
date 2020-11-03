using Microsoft.AspNetCore.Mvc;
using System;

namespace RPSAPI.Controllers
{

    [ApiController]

    public class ResultController : ControllerBase
    {
        public ResultController()
        {
        }

        [HttpPost("GetResult")]
        public string getresults(string playerselection)
        {
            Console.WriteLine(playerselection);
            Random r = new Random();
            int computerChoice = r.Next(4);
            int playerwins = 0;
            int computerwins = 0;
            int tiedgame = 0;

            Console.WriteLine(computerChoice);

            if (computerChoice == 1)
            //rock
            {
                if (playerselection == "rock")
                {
                    tiedgame++;
                }
                else if (playerselection == "paper")
                //paper
                {
                    playerwins++;
                }
                else if (playerselection == "scissors")
                {
                    computerwins++;
                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");
                }
            }
            else if (computerChoice == 2)
            //Paper
            {
                if (playerselection == "rock")
                {
                    computerwins++;
                }
                else if (playerselection == "paper")
                {
                    tiedgame++;
                }
                else if (playerselection == "scissors")
                {
                    playerwins++;
                }
            }
            else if (computerChoice == 3)
            //scissors
            {
                if (playerselection == "rock")
                {
                    playerwins++;
                }
                else if (playerselection == "paper")
                {
                    computerwins++;
                }
                else if (playerselection == "scissors")
                {
                    tiedgame++;
                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");
                }
            }

            if (playerwins > computerwins)
            {
                return "You won!";
            }
            else
            {
                if (playerwins < computerwins)
                {
                    return "You lost! :( ";
                }
            }
            return "no";
        }
    }
}