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
      Player player1 = new Player();

      Player result = player1;

      Assert.AreEqual(typeof(Player), result.GetType());
    }
  }
}