using CharacterSheetJSON.Models.Enums;
using CharacterSheetJSON.Models.Factories;

var character = CharacterFactory.CreateCharacter("Gandalf", 1, CharacterClasses.WIZARD);
var barbarian = CharacterFactory.CreateCharacter("Grog", 1, CharacterClasses.BARBARIAN);
var rogue = CharacterFactory.CreateCharacter("Astarion", 1, CharacterClasses.ROGUE);

System.Console.WriteLine(character);
System.Console.WriteLine(barbarian.GetType());
