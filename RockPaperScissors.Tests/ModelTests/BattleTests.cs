using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System;


namespace RockPaperScissors.Tests 
{
  [TestClass]
  public class BattleTests
  {
    [TestMethod]
    public void CreateBattle_CreateBattle_TypeBattle()
    {
      Player player1 = new Player("Ven");
      Player player2 = new Player("Keturah");
      Battle newBattle = new Battle(player1, player2);

      Battle result = newBattle;

      Assert.AreEqual(typeof(Battle), result.GetType());
    }
    [TestMethod]
    public void CompareWeapons_ComparePlayersWeapons_WeaponStrings()
    {
      Player player1 = new Player("Ven");
      Player player2 = new Player("Keturah");
      player1.AssaignWeapon("r");
      player2.AssaignWeapon("p");
      Battle newBattle = new Battle(player1, player2);

      string comparison = newBattle.Versus();

      Assert.AreEqual("Rock vs Paper", comparison);
    }
    [TestMethod]
    public void DisplayWinner_DisplayPresetWinnerToBeNoOne_NoOne()
    {
      Player player1 = new Player("Ven");
      Player player2 = new Player("Keturah");
      Battle newBattle = new Battle(player1, player2);

      string winner = newBattle.Winner.Name;

      Assert.AreEqual("No-One", winner);
    }
    [TestMethod]
    public void DecideWinner_CalculateWinnerByComparingTheirWeapons_Winner()
    {
      Player player1 = new Player("Ven");
      Player player2 = new Player("Keturah");
      player1.AssaignWeapon("r");
      player2.AssaignWeapon("p");
      Battle newBattle = new Battle(player1, player2);

      string winner = newBattle.Versus();

      Assert.AreEqual("Keturah", winner);
    }
  }
}