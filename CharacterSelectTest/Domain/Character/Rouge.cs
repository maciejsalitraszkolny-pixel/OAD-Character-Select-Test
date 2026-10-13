using CharacterSelectTest.Application;
using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Character;

/*
klasa: Rouge
opis: reprezentuje postać łotrzycy
przyznaczenie: ataki z tyłu
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
public sealed class Rouge : Entity.Character
{
    public Rouge(string name) : base(name, CharacterClass.Rouge)
    {
        Health = 95;
        Strength = 9;
        Intelligence = 8;
        Agility = 15;
        Defence = 5;
        Speed = 20;
        Attack = Intelligence * 3;
        SpecialAttack = "Backstab";
    }
}