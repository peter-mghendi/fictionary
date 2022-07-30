namespace Fictionary.FreeDictionary.Models;

public class Entry
{
    public string Word { get; set; } = null!;
    public string Phonetic { get; set; } = null!;
    public List<Phonetic> Phonetics { get; set; } = new();
    public string Origin { get; set; } = null!;
    public List<Meaning> Meanings { get; set; } = new();
}