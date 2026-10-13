using CharacterSelectTest.Domain.Enum;

namespace CharacterSelectTest.Domain.Entity;

public abstract class Character
{
    public string Name { get; set; }
    public CharacterClass Class { get; }
    public int Health { get; protected set; }
    public int Strength { get; protected set; }
    public int Intelligence { get; protected set; }
    public int Agility { get; protected set; }
    /*
    metoda: Defence
    opis: Zwraca lub ustawia obronę postaci.
    parametry: int Defence - obrona postaci.
    zwraca: int - obrona postaci.
    */
    public int Defence { get; protected set;}
    /*
    metoda: Speed
    opis: Zwraca lub ustawia szybkość postaci.
    parametry: int Speed - szybkość postaci.
    zwraca: int - szybkość postaci.
    */
    public int Speed { get; protected set; }
    /*
    metoda: Attack
    opis: Zwraca lub ustawia atak postaci.
    parametry: int Attack - atak postaci.
    zwraca: int - atak postaci.
    */
    public int Attack { get; protected set; }
    /*
    metoda: SpecialAttack
    opis: Zwraca lub ustawia specjalny atak postaci.
    parametry: string SpecialAttack - specjalny atak postaci.
    zwraca: string - specjalny atak postaci.
    */
    public string SpecialAttack { get; protected set; }

    protected Character(string name, CharacterClass @class)
    {
        Name = string.IsNullOrWhiteSpace(name) ? @class.ToString() : name.Trim();
        Class = @class;
    }

    public virtual void Describe()
    {
        Console.WriteLine($"[{Class}] {Name}");
        Console.WriteLine($"  HP: {Health}");
        Console.WriteLine($"  STR: {Strength}  INT: {Intelligence}  AGI: {Agility} DEF: {Defence} SPD: {Speed} ATK: {Attack}");
        Console.WriteLine($"  SPC-ATK: {SpecialAttack} ");
    }
}