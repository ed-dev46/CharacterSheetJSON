namespace CharacterSheetJSON;

public class Wizard : Character
{
    private int baseLifePoints = 6;
    private int baseManaPoints = 12;

    public Wizard(string name, int level) : base(name, level)
    {
        LifePoints = (int)(baseLifePoints + Math.Floor(Level / 2.0));
        ManaPoints = (int)(baseManaPoints + Math.Floor(Level * 2.0));
        Attributes["Intelligence"] = 14;
        Attributes["Constitution"] = 8;
    }
}