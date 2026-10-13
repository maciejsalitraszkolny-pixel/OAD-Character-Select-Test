using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

/*
klasa: Mage
opis: reprezentuje postać maga
przyznaczenie: ataki magiczne
pola / właściwości:
    Name, string, nazwa postaci
    Health, int, punkty życia postaci
    Inteligence, int, inteligencja postaci
    Strength, int, moc postaci
    Agility, int, zręczność postaci
    Defence, int, obrona postaci
    Speed, int, prędkość postaci
    Attack, int, atak postaci
    SpecialAttack, string, specjalny atak postaci
*/
public sealed class Mage : Entity.Character
{
    public Mage(string name) : base(name, CharacterClass.Mage)
    {
        Health = 80;
        Strength = 4;
        Intelligence = 16;
        Agility = 10;
        Defence = 5;
        Speed = 15;
        Attack = Intelligence * 3;
        SpecialAttack = "Fireball";
    }
}