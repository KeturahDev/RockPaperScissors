using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockerPaperScissors.TestTools
{
  [TestClass]
  public class PlayerTests 
  {
    [TestMethod]
    public void ConstructPlayer_CreatesPlayer_Player()
    {
      Player player1 = new Player("Mimi");

      Player result = player1;

      Assert.AreEqual(typeof(Player), result.GetType());
    }
    [TestMethod]
    public void GivePlayerName_AssaignNamePropsToPlayer_String()
    {
      string name = "Benji";
      Player player1 = new Player(name);

      string result = player1.Name;

      Assert.AreEqual(name, result);
    }
  }
}