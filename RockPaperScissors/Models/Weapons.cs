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
      Type = "fail test";
    }
  }
}