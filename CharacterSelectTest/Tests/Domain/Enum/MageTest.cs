using CharacterSelectTest.Domain.Enum;
using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Enum;

[TestClass]
public class MageTest
{
    [TestMethod]
    public void TestIsAbleToMakeNewInstance()
    {
        Assert.IsExactInstanceOfType<Mage>(new Mage("Gandalf"));
    }
    [TestMethod]
    public void TestState()
    {
        Mage mage = new Mage("Gandalf");
        Assert.AreEqual(80, mage.Health);
        Assert.AreEqual(4, mage.Strength);
        Assert.AreEqual(16, mage.Intelligence);
        Assert.AreEqual(10, mage.Agility);
        Assert.AreEqual(5, mage.Defence);
        Assert.AreEqual(15, mage.Speed);
        int health = mage.Health;
        int strength = mage.Strength;
        int intelligence = mage.Intelligence;
        int agility = mage.Agility;
        int defence = mage.Defence;
        int speed = mage.Speed;
        Assert.AreEqual(48, mage.Attack);
        int damage = mage.Attack;
        damage = mage.Intelligence * 3;
        Assert.AreEqual($"Fireball", mage.SpecialAttack);
    }
}