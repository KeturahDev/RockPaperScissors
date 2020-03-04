namespace RockPaperScissors.Models
{
  public class Weapon
  {
    string[] options = {"Rock", "Paper", "Scissors"};
    public string[] Options {get;}
    public Weapon()
    {
      Options = options;
    }
  }
}