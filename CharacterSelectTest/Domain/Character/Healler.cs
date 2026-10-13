using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

/* 
klasa: Healler
opis: reprezentuje postać lekarza
przyznaczenie: leczenie innych postaci
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
public sealed class Healler : Entity.Character
{
    public Healler(string name) : base(name, CharacterClass.Healler)
    {
        Health = 50;
        Strength = 2;
        Intelligence = 50;
        Agility = 5;
        Defence = 3;
        Speed = 30;
        Attack = Intelligence * 3;
        SpecialAttack = "Heal";
    }
}