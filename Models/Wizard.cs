namespace CharacterSheetJSON.Models;

using CharacterSheetJSON.Models.Enums;

public class Wizard : Character
{
    public Wizard(string name, int level) : base(name, level)
    {
        _baseLifePoints = 6;
        _baseManaPoints = 12;

        LifePoints = (int)(_baseLifePoints + Math.Floor(Level / 2.0));
        ManaPoints = (int)(_baseManaPoints + Math.Floor(Level * 2.0));

        attributes[CharacterAttributes.INT] = 14;
        attributes[CharacterAttributes.CON] = 8;

        skills["Passive"] = "Arcana Rest";
        skills["Active"] = "Magic Missile";
        skills["Super"] = "Fireball";
    }
}