using System.Net.Http.Json;
using BlazorDragonBallApi.Models;

namespace BlazorDragonBallApi.Services
{
    public class DragonBallService
    {
        private readonly HttpClient _http;

        public DragonBallService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Character?> BuscarPersonagem(int id)
        {
            try
            {
                return await _http.GetFromJsonAsync<Character>(
                    $"https://dragonball-api.com/api/characters/{id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}