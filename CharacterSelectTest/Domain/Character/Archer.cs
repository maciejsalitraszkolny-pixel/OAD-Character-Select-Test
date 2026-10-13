using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

/* 
klasa: Archer
opis: reprezentuje postać łucznika
przyznaczenie: ataki na odległości
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
public sealed class Archer : Entity.Character
{
    public Archer(string name) : base(name, CharacterClass.Archer)
    {
        Health = 40;
        Strength = 6;
        Intelligence = 70;
        Agility = 15;
        Defence = 5;
        Speed = 10;
        Attack = Intelligence * 3;
        SpecialAttack = "Precise Shot";
    }
}