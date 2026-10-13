using CharacterSelectTest.Domain.Character;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Application.Factory;

public static class CharacterFactory
{
    public static Domain.Entity.Character Create(CharacterClass cls, string? name)
    {
        return cls switch
        {
            CharacterClass.Warrior => new Warrior(name ?? "Warrior"),
            CharacterClass.Mage    => new Mage(name ?? "Mage"),
            CharacterClass.Rouge   => new Rouge(name ?? "Rouge"),
            CharacterClass.Healler => new Healler(name ?? "Healler"),
            CharacterClass.Killer  => new Killer(name ?? "Killer"),
            CharacterClass.Archer  => new Archer(name ?? "Archer"),
            _ => throw new ArgumentOutOfRangeException(nameof(cls), "Nieznana klasa postaci.")
        };
    }
}