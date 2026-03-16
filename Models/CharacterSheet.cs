using System.Text.Json;
using System.IO;
using CharacterSheetJSON.Models;

namespace CharacterSheetJSON;

public static class CharacterSheet
{
    public static void SaveNewSheet(Character character)
    {
        string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"CharactersSheets");
        string characterFilePath = Path.Combine(directoryPath, $"{character.Name.ToLower()}.json");
        string allCharactersFilePath = Path.Combine(directoryPath, "Characters.json");

        var options = new JsonSerializerOptions { WriteIndented = true };

        string jsonString = JsonSerializer.Serialize(character, options);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
            Console.WriteLine($"Directory created in {directoryPath}");
        }

        File.WriteAllText(characterFilePath, jsonString);
        File.AppendAllText(allCharactersFilePath, jsonString);

    }
}
