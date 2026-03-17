using System.Text.Json;
using CharacterSheetJSON.Models;

namespace CharacterSheetJSON;

public static class CharacterSheet
{
    public static async Task SaveNewSheet(Character character)
    {
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CharacterSheets");
        string allCharactersSheet = Path.Combine(path, "Characters.json");

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);

            Console.WriteLine($"Directory created in {path}");
        }

        var options = new JsonSerializerOptions() { WriteIndented = true };
        string characterString = JsonSerializer.Serialize(character, options);
        await File.WriteAllTextAsync(Path.Combine(path, character.Name.Replace(" ", "-").ToLower() + ".json"), characterString);

        List<Character> charactersList = new List<Character>();


        if (File.Exists(allCharactersSheet))
        {
            string charactersContent = await File.ReadAllTextAsync(allCharactersSheet);
            charactersList = JsonSerializer.Deserialize<List<Character>>(charactersContent, options);
        }

        charactersList.Remove(charactersList.FirstOrDefault(x => x.Name == character.Name));

        charactersList.Add(character);

        string charactersListJson = JsonSerializer.Serialize<List<Character>>(charactersList, options);
        await File.WriteAllTextAsync(allCharactersSheet, charactersListJson);
        
    }
}
