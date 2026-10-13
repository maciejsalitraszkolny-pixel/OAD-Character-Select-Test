using CharacterSelectTest.Domain.Enum;
using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Enum;

[TestClass]
public class KillerTest
{
    [TestMethod]
    public void TestIsAbleToMakeNewInstance()
    {
        Assert.IsExactInstanceOfType<Killer>(new Killer("Dragos"));
    }
    [TestMethod]
    public void TestStats()
    {
        Killer killer = new Killer("Dragos");
        Assert.AreEqual(150, killer.Health);
        Assert.AreEqual(20, killer.Strength);
        Assert.AreEqual(90, killer.Intelligence);
        Assert.AreEqual(50, killer.Agility);
        Assert.AreEqual(10, killer.Defence);
        Assert.AreEqual(20, killer.Speed);
        int health = killer.Health;
        int strength = killer.Strength;
        int intelligence = killer.Intelligence;
        int agility = killer.Agility;
        int defence = killer.Defence;
        int speed = killer.Speed;
        Assert.AreEqual(270, killer.Attack);
        int damage = killer.Attack;
        damage = killer.Intelligence * 3;
        Assert.AreEqual($"Assassinate", killer.SpecialAttack);
    }
}