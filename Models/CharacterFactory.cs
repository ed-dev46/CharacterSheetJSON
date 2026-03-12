namespace CharacterSheetJSON.Models.Factories;

using CharacterSheetJSON.Models.Enums;

public static class CharacterFactory
{
    public static Character CreateCharacter(string name, int level, CharacterClasses characterClass)
    {
        switch (characterClass)
        {
            case CharacterClasses.WIZARD:
                return new Wizard(name, level);
            case CharacterClasses.ROGUE:
                return new Rogue(name, level);
            case CharacterClasses.BARBARIAN:
                return new Barbarian(name, level);
            default:
                throw new ArgumentException("Invalid character class");
        }
    }
}