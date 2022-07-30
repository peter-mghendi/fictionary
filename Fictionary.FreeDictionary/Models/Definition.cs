namespace Fictionary.FreeDictionary.Models;

public class MeaningDefinition
{
    public string Definition { get; set; } = null!;
    public string Example { get; set; } = null!;
    public string[] Synonyms { get; set; } = null!;
    public string[] Antonyms { get; set; } = null!;
}