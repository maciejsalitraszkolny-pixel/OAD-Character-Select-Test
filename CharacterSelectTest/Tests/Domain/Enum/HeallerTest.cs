using CharacterSelectTest.Domain.Enum;
using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Enum;

[TestClass]
public class HeallerTest
{
    [TestMethod]
    public void TestIsAbleToMakeNewInstance()
    {
        Assert.IsExactInstanceOfType<Healler>(new Healler("Helen"));
    }

    [TestMethod]
    public void TestStats()
    {
        Healler healler = new Healler("Helen");
        Assert.AreEqual(50, healler.Health);
        Assert.AreEqual(2, healler.Strength);
        Assert.AreEqual(50, healler.Intelligence);
        Assert.AreEqual(5, healler.Agility);
        Assert.AreEqual(3, healler.Defence);
        Assert.AreEqual(30, healler.Speed);
        int health = healler.Health;
        int strength = healler.Strength;
        int intelligence = healler.Intelligence;
        int agility = healler.Agility;
        int defence = healler.Defence;
        int speed = healler.Speed;
        Assert.AreEqual(150, healler.Attack);
        int damage = healler.Attack;
        damage = healler.Intelligence * 3;
        Assert.AreEqual($"Heal", healler.SpecialAttack);
    }
}

