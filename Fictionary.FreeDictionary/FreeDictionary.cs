using Fictionary.FreeDictionary.Services;

namespace Fictionary.FreeDictionary;

public class FreeDictionary
{
    private const string BaseUrl = "https://api.dictionaryapi.dev/api/v2/entries/en/";

    public static EntriesService Entries { get; } = new(BaseUrl);
}