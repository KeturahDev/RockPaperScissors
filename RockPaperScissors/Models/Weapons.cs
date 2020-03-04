using System;

namespace RockPaperScissors.Models
{
  public class Weapon
  {
    string[] options = {"Rock", "Paper", "Scissors"};
    public string[] Options {get;}
    public string Type {get; set;}
    public Weapon()
    {
      Options = options;
      Type = options[0];
    }
    public void AssaignType(string rquestedType)
    {
      rquestedType.ToLower();
      if (rquestedType == "rock" || rquestedType == "r")
      {
        Type = options[0];
      }
      else if (rquestedType == "paper" || rquestedType == "p")
      {
        Type = options[1];
      }
      else if (rquestedType == "scissors" || rquestedType == "s")
      {
        Type = options[2];
      }
      else
      {
        //potentially use try catch block here, with if statments in try, and else acting as catch, and asking user to input correct inputs
      }
    }
  }
}