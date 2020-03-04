namespace RockPaperScissors.Models
{
  public class Player
  {
    public string Name{get;set;}
    public string Weapon{get;set;}
    public Player(string name)
    {
      Name = name;
      Weapon = "none";
    }
  }
}