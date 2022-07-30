using Fictionary.FreeDictionary.Models;
using Flurl.Http;

namespace Fictionary.FreeDictionary.Services;

public class EntriesService
{
    public EntriesService(string baseUrl) => BaseUrl = baseUrl;

    private string BaseUrl { get; }
    
    public async Task<List<Entry>> GetAsync(string word) => await $"{BaseUrl}/{word}".GetJsonAsync<List<Entry>>();
}