namespace CharacterSheetJSON.Models;

using CharacterSheetJSON.Models.Enums;

public class Rogue : Character
{
    public Rogue(string name, int level) : base(name, level)
    {
        _baseLifePoints = 8;
        _baseManaPoints = 8;

        LifePoints = (int)(_baseLifePoints + Math.Floor(Level / 2.0));
        ManaPoints = _baseManaPoints + Level;

        attributes[CharacterAttributes.DEX] = 14;
        attributes[CharacterAttributes.WIN] = 8;

        skills["Passive"] = "Sneak Attack";
        skills["Active"] = "Throw Daggers";
        skills["Super"] = "Smoke Bomb";
    }
}
