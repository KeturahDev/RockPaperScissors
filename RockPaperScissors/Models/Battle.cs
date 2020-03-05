namespace RockPaperScissors.Models
{
  public class Battle
  {
    // string[] victoryStatus = {"Winner", "Draw"};
    Player representingDraw = new Player("No-One");
    public Player Player1 {get;set;}
    public Player Player2 {get;set;}
    public Player Winner {get;set;}
    public Battle(Player player1, Player player2)
    {
      Player1 = player1;
      Player2 = player2;
      Winner = representingDraw;
    }

    public string Versus()
    {
      // string comparison = Player1.Weapon + " vs " + Player2.Weapon;
      // return comparison;
      string weapon1 = Player1.Weapon;
      string weapon2 = Player2.Weapon;
      return "fail test";
      // if (weapon1 == "Rock")
      // {
      //   if (weapon2 == "Rock")
      //   {
      //   }
      //   else if (weapon2 == "Paper")
      //   {
      //     Winner = Player2
      //   }
      //   else if (weapon2 == "Scissors")
      //   {
      //     Winner = Player1
      //   }
      // }
      // else if (weapon1 == "Paper")
      // {
      //   if (weapon2 == "Rock")
      //   {
      //     Winner = Player1;
      //   }
      //   else if (weapon2 == "Paper")
      //   {
      //   }
      //   else if (weapon2 == "Scissors")
      //   {
      //     Winner = Player2;
      //   }
      // }
      // else if (weapon1 == "Scissors")
      // {
      //   if (weapon2 == "Rock")
      //   {
      //     Winner = Player2;
      //   }
      //   else if (weapon2 == "Paper")
      //   {
      //     Winner = Player1;
      //   }
      //   else if (weapon2 == "Scissors")
      //   {
      //   }
      // }
      // return Winner.Name;
    }
  }
}