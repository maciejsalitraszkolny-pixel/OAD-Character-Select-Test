using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

/* 
 klasa: Killer
 opis: Klasa reprezentująca postać murdercę
 przyznaczenie: ciche ataki przeciwników
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
public sealed class Killer : Entity.Character
{
    public Killer(string name) : base(name, CharacterClass.Killer)
    {
        Health = 150;
        Strength = 20;
        Intelligence = 90;
        Agility = 50;
        Defence = 10;
        Speed = 20;
        Attack = Intelligence * 3;
        SpecialAttack = "Assassinate";
    }
}