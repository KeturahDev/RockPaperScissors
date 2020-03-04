using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockerPaperScissors.Tests
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
    [TestMethod]
    public void PlayersWeapon_GivePlayersAWeapon_String()
    {
      string name = "Benji";
      Player player1 = new Player(name);
      string weaponOfChoice = "rock";

      player1.Weapon = weaponOfChoice;

      Assert.AreEqual(weaponOfChoice, player1.Weapon);
    }
    [TestMethod]
    public void GetWeapon_AssaignPlayerAWeapon_WeaponType()
    {
      //player is prompted to give name
      string name = "Benji";
      Player player1 = new Player(name);
      Weapon player1Weapon = new Weapon();
      //player is prompted to choose a weapon [rock(r), paper(p), or scissors(s)]
      string chooseAWeaponResonse = "paper";

      player1Weapon.AssaignType(chooseAWeaponResonse);
      player1.Weapon = player1Weapon.Type;

      Assert.AreEqual("Paper", player1.Weapon);
    }
  }
}