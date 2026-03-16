using CharacterSheetJSON.Models.Enums;
using CharacterSheetJSON.Models.Factories;

var character = CharacterFactory.CreateCharacter("Merlin", 1, CharacterClasses.WIZARD);
var barbarian = CharacterFactory.CreateCharacter("Conan", 2, CharacterClasses.BARBARIAN);

Console.WriteLine(character);
