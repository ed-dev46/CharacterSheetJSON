namespace CharacterSheetJSON;

public abstract class Character
{
    public string Name { get; set; }
    public int Level { get; }
    public int LifePoints { get; protected set; }
    public int ManaPoints { get; protected set; }
    public Dictionary<string, int> Attributes = new Dictionary<string, int>
    {
        { "Strength", 10 }, // modificadores = divida por dois e diferenca para 5
        { "Dexterity", 10 },
        { "Intelligence", 10 },
        { "Constitution", 10 },
        { "Wisdom", 10 },
        { "Charisma", 10 }
    };
    public Dictionary<string, string> _skills = new Dictionary<string, string>()
    {
        {"Passive", "-"},
        {"Attack", "-"},
        {"Super", "-"}
    };

    public Character(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public override string ToString()
    {
        return $"{Name}, Lv{Level}\n"
        + $"LP:{LifePoints} - MP:{ManaPoints}";
    }
}
