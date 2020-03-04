namespace RockPaperScissors.Models
{
  public class Battle
  {
    public Player Player1 {get;set;}
    public Player Player2 {get;set;}
    public Battle(Player player1, Player player2)
    {
      Player1 = player1;
      Player2 = player2;
    }

    public string Versus()
    {
      string comparison = Player1.Weapon + " vs " + Player2.Weapon;
      return comparison;
    }
  }
}