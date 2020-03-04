using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class WeaponTests
  {
    [TestMethod]
    public void ConstructWeapon_CreateInstancesOfWeapon_WeaponType()
    {
      Weapon newWeapon = new Weapon();
      
      Weapon result = newWeapon;

      Assert.AreEqual(typeof(Weapon), result.GetType());
    }
  }
}