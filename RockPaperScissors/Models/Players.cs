namespace RockPaperScissors.Models
{
  public class Player
  {
    string[] options = {"Rock", "Paper", "Scissors"};

    public string Name{get;set;}
    public string Weapon{get;set;}
    public Player(string name)
    {
      Name = name;
      Weapon = "none";
    }
    public void AssaignWeapon(string rquestedWeapon)
    {
      rquestedWeapon.ToLower();
      if (rquestedWeapon == "rock" || rquestedWeapon == "r")
      {
        Weapon = options[0];
      }
      else if (rquestedWeapon == "paper" || rquestedWeapon == "p")
      {
        Weapon = options[1];
      }
      else if (rquestedWeapon == "scissors" || rquestedWeapon == "s")
      {
        Weapon = options[2];
      }
      else
      {
        //potentially use try catch block here, with if statments in try, and else acting as catch, and asking user to input correct inputs
      }
    }
  }
}