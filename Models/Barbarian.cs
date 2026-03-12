namespace CharacterSheetJSON.Models;

using CharacterSheetJSON.Models.Enums;

public class Barbarian : Character
{
    public Barbarian(string name, int level) : base(name, level)
    {
        _baseLifePoints = 12;
        _baseManaPoints = 6;

        LifePoints = (int)(_baseLifePoints + Math.Floor(Level * 2.0));
        ManaPoints = (int)(_baseManaPoints + Math.Floor(Level / 2.0));

        attributes[CharacterAttributes.STR ] = 14;
        attributes[CharacterAttributes.INT] = 8;

        skills["Passive"] = "Big Weapons";
        skills["Active"] = "Extra Attack";
        skills["Super"] = "Rage";
    }
}
