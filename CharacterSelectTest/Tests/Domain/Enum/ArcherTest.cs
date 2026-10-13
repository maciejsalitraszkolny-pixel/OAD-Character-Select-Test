using CharacterSelectTest.Domain.Enum;
using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Enum;

[TestClass]
public class ArcherTest
{
    [TestMethod]
    public void TestIsAbleToMakeNewInstance()
    {
        Assert.IsExactInstanceOfType<Archer>(new Archer("Legolas"));
    }

    [TestMethod]
    public void TestStats()
    {
        Archer archer = new Archer("Legolas");
        Assert.AreEqual(40, archer.Health);
        Assert.AreEqual(6, archer.Strength);
        Assert.AreEqual(70, archer.Intelligence);
        Assert.AreEqual(15, archer.Agility);
        Assert.AreEqual(5, archer.Defence);
        Assert.AreEqual(10, archer.Speed);
        int health = archer.Health;
        int strength = archer.Strength;
        int intelligence = archer.Intelligence;
        int agility = archer.Agility;
        int defence = archer.Defence;
        int speed = archer.Speed;
        Assert.AreEqual(210, archer.Attack);
        int damage = archer.Attack;
        damage = archer.Intelligence * 3;
        Assert.AreEqual($"Precise Shot", archer.SpecialAttack);
    }
}