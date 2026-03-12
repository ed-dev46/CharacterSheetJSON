namespace CharacterSheetJSON.Models;

using CharacterSheetJSON.Models.Enums;

public abstract class Character
{
    public string Name { get; set; }
    public int Level { get; }
    protected int _baseLifePoints { get; set; }
    public int LifePoints { get; protected set; }
    protected int _baseManaPoints { get; set; }
    public int ManaPoints { get; protected set; }
    public Dictionary<CharacterAttributes, int> attributes = new Dictionary<CharacterAttributes, int>
    {
        // modificadores = divida por dois e diferenca para 5
        { CharacterAttributes.STR, 10 },
        { CharacterAttributes.DEX, 10 },
        { CharacterAttributes.CON, 10 },
        { CharacterAttributes.INT, 10 },
        { CharacterAttributes.WIN, 10 },
        { CharacterAttributes.CHA, 10 }
    };
    public Dictionary<string, string> skills = new Dictionary<string, string>()
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

    public string getAttributes()
    {
        string characterAttributes = $"";
        foreach(var attribute in attributes)
        {
            characterAttributes += $"{attribute.Key}: {attribute.Value}\n";
        }
        return characterAttributes;
    }

    public override string ToString()
    {
        return $"{Name}, Lv{Level}\n"
        + $"LP:{LifePoints} - MP:{ManaPoints}\n"
        + $"---------------------------------\n"
        + $"[Skills]\n"
        + $"Passive: {skills["Passive"]}\n"
        + $"Active: {skills["Active"]}\n"
        + $"Super: {skills["Super"]}\n"
        + $"---------------------------------\n"
        + $"[Attributes]\n"
        + getAttributes();
    }
}
