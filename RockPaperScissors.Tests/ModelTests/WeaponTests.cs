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
    [TestMethod]
    public void AssaignWeaponType_GiveWeaponsAnOptionTypeProperty_OptionPropType()
    {
      Weapon newWeapon = new Weapon();
      string weaponOfChoice = "rock";

      newWeapon.AssaignType(weaponOfChoice);

      Assert.AreEqual("Rock", newWeapon.Type);

    }
  }
}