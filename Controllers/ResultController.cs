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
            int computerChoice = r.Next(4);
            int playerwins = 0;
            int computerwins = 0;
            int tiedgame = 0;

            string playerselection = playerschoice.PlayerSelection;

            Console.WriteLine($"firstcomputer record: {computerChoice}");
            Console.WriteLine($"you chose: {playerselection}");

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
                //////// else
                ////// {
                //////    // Console.WriteLine("You must choose rock,paper or scissors!");
                ////// }
            }
            resultsclass result = new resultsclass();

           
            Console.WriteLine($"youwon this many times: {playerwins}");
            Console.WriteLine(computerwins);
            Console.WriteLine(tiedgame);

            //if(playerwins) { return "you won"} else if(computerwins) { return "you lost} else { return "it was a tie}

            if (playerwins > computerwins)
            {
                result.ResultofGame = $"You chose: {playerselection} and won!";
                Console.WriteLine(result);
                
                return result;
            }
            else if (playerwins < computerwins)
                {
                    result.ResultofGame = $"The computer chose: {computerChoice} and you lose!";
                    Console.WriteLine(result);
                    
                    return result;
                }
           else
                {
                    //tiedgame

                    result.ResultofGame = $"The computer chose: {computerChoice} and you chose: {playerselection}, it is a tie!";
                    Console.WriteLine(result);
                   
                    return result;
                }
            }
        }
    }