using CharacterSheetJSON.Models.Enums;
using CharacterSheetJSON.Models.Factories;

var character = await CharacterFactory.CreateCharacter("Astarion", 1, CharacterClasses.WIZARD);
var levelUp = await CharacterFactory.CreateCharacter("Astarion", 10, CharacterClasses.WIZARD);
var character2 = await CharacterFactory.CreateCharacter("Astarion", 3, CharacterClasses.BARBARIAN);

