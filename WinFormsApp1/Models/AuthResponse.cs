using System.Text.Json.Serialization;

namespace WinFormsApp1.Models
{
    public record AuthResponse
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
    }
}
