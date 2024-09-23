using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class CharacterService
{
    private readonly HttpClient _httpClient;

    public CharacterService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CharacterResponse> GetCharacters(int page = 1)
    {
        return await _httpClient.GetFromJsonAsync<CharacterResponse>($"https://rickandmortyapi.com/api/character?page={page}");
    }
}
