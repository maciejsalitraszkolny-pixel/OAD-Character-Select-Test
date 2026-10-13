using CharacterSelectTest.Domain.Enum;
using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Enum;

[TestClass]
public class WarriorTest
{
    [TestMethod]
    public void TestIsAbleToMakeNewInstance()
    {
        Assert.IsExactInstanceOfType<Warrior>(new Warrior("Aragorn"));
    }

    [TestMethod]
    public void TestStats()
    {
        Warrior warrior = new Warrior("Aragorn");
        Assert.AreEqual(120, warrior.Health);
        Assert.AreEqual(14, warrior.Strength);
        Assert.AreEqual(6, warrior.Intelligence);
        Assert.AreEqual(8, warrior.Agility);
        Assert.AreEqual(10, warrior.Defence);
        Assert.AreEqual(15, warrior.Speed);
        int health = warrior.Health;
        int strength = warrior.Strength;
        int intelligence = warrior.Intelligence;
        int agility = warrior.Agility;
        int defence = warrior.Defence;
        int speed = warrior.Speed;
        Assert.AreEqual(18, warrior.Attack);
        int damage = warrior.Attack;
        damage = warrior.Intelligence * 3;
        Assert.AreEqual($"Power Strike", warrior.SpecialAttack);
    }
}