using CharacterSelectTest.Domain.Enum;
using CharacterSelectTest.Domain.Entity;
using CharacterSelectTest.Domain.Character;

namespace CharacterSelectTest.Tests.Domain.Enum;

[TestClass]
public class RougeTest
{
    [TestMethod]
    public void TestIsAbleToMakeNewInstance()
    {
        Assert.IsExactInstanceOfType<Rouge>(new Rouge("Thieves"));
    }
    [TestMethod]
    public void TestState()
    {
        Rouge rouge = new Rouge("Thieves");
        Assert.AreEqual(95, rouge.Health);
        Assert.AreEqual(9, rouge.Strength);
        Assert.AreEqual(8, rouge.Intelligence);
        Assert.AreEqual(15, rouge.Agility);
        Assert.AreEqual(5, rouge.Defence);
        Assert.AreEqual(20, rouge.Speed);
        int health = rouge.Health;
        int strength = rouge.Strength;
        int intelligence = rouge.Intelligence;
        int agility = rouge.Agility;
        int defence = rouge.Defence;
        int speed = rouge.Speed;
        Assert.AreEqual(24, rouge.Attack);
        int damage = rouge.Attack;
        damage = rouge.Intelligence * 3;
        Assert.AreEqual($"Backstab", rouge.SpecialAttack);
    }
}