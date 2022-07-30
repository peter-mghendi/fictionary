namespace Fictionary.FreeDictionary.Models;

public class Meaning
{
    public string PartOfSpeech { get; set; } = null!;
    public List<MeaningDefinition> Definitions { get; set; } = new();
}