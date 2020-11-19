using Microsoft.AspNetCore.Mvc;
using RPSAPI.models;
using System;
using System.Text.Json;

namespace RPSAPI.Controllers
{
    [ApiController]
    public class ResultController : ControllerBase
    {
        public ResultController()
        {
        }

        [HttpPost("GetResult")]

        // public SubmitPlayModel SubmitPlay({ FromBody} SubmitPlayRequestModel model)
        public resultsclass getresults(playerchoiceclass playerschoice)

        {
            //Console.WriteLine(playerselection);
            Random r = new Random();
            int computerChoice = r.Next(1, 4);
            int playerwins = 0;
            int computerwins = 0;
            int tiedgame = 0;

            string playerselection = playerschoice.PlayerSelection;

            Console.WriteLine($"firstcomputer record: {computerChoice}");
            Console.WriteLine($"you chose: {playerselection}");



            if (computerChoice == 1)
                //rock
     
            {
                Console.WriteLine($"this cpu choice is {computerChoice}");
                Console.WriteLine($"this player selection choice is {playerselection}");
                if (playerselection == "Rock")
                {
                    tiedgame++;

                }
                else if (playerselection == "Paper")
                //paper
                {
                    playerwins++;
                }
                else if (playerselection == "Scissors")
                {
                    computerwins++;
                }
        
            }
            else if (computerChoice == 2)
            //Paper
            {
                Console.WriteLine($"this cpu choice is {computerChoice}");
                Console.WriteLine($"this player selection choice is {playerselection}");
                if (playerselection == "Rock")
                {
                    computerwins++;
                }
                else if (playerselection == "Paper")
                {
                    tiedgame++;
                }
                else if (playerselection == "Scissors")
                {
                    playerwins++;
                }
            }
            else if (computerChoice == 3)
            //scissors
            {
                Console.WriteLine($"this cpu choice is {computerChoice}");
                Console.WriteLine($"this player selection choice is {playerselection}");
                if (playerselection == "Rock")
                {
                    playerwins++;
                }
                else if (playerselection == "Paper")
                {
                    computerwins++;
                }
                else if (playerselection == "Scissors")
                {
                    tiedgame++;
                }
                //////// else
                ////// {
                //////    // Console.WriteLine("You must choose rock,paper or scissors!");
                ////// }
            }
            resultsclass result = new resultsclass();

           
            Console.WriteLine($"you won this many times: {playerwins}");
            Console.WriteLine(computerwins);
            Console.WriteLine(tiedgame);

            //if(playerwins) { return "you won"} else if(computerwins) { return "you lost} else { return "it was a tie}

            if (playerwins > computerwins)
            {
                result.ResultofGame = $"You chose: {playerselection} and won!";
                Console.WriteLine(result);
                
                return result;
            }
           if (playerwins < computerwins)
                {
                    result.ResultofGame = $"The computer chose: {computerChoice} and you lose!";
                    Console.WriteLine(result);
                    
                    return result;
                }
           if (playerwins == computerwins)
                {
                    //tiedgame

                    result.ResultofGame = $"The computer chose: {computerChoice} and you chose: {playerselection}, it is a tie!";
                    Console.WriteLine(result);
                   
                    return result;
                }
            else
            {
                return result;
            }
            }
        }
    }