namespace CharacterSheetJSON.Models.Factories;

using CharacterSheetJSON.Models.Enums;

public static class CharacterFactory
{
    public static async Task<Character> CreateCharacter(string name, int level, CharacterClasses characterClass)
    {
        Character newCharacter;
        switch (characterClass)
        {
            case CharacterClasses.WIZARD:
                newCharacter = new Wizard(name, level);
                break;
            case CharacterClasses.ROGUE:
                newCharacter = new Rogue(name, level);
                break;
            case CharacterClasses.BARBARIAN:
                newCharacter = new Barbarian(name, level);
                break;
            default:
                throw new ArgumentException("Invalid character class");
        }
        await CharacterSheet.SaveNewSheet(newCharacter);
        return newCharacter;
    }
}