using System.Text.Json.Serialization;

namespace BlazorDragonBallApi.Models
{
    public class Character
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("originPlanet")]
        public Planet? OriginPlanet { get; set; }

        [JsonPropertyName("transformations")]
        public List<Transformation>? Transformations { get; set; }
    }

    public class Planet
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public class Transformation
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}