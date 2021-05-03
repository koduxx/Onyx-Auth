using System.Text.Json.Serialization;

namespace onyx.LOGIN
{
  public class Exchange
  {
    [JsonPropertyName("expiresInSeconds")]
    public int ExpiresInSeconds { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("creatingClientId")]
    public string CreatingClientId { get; set; }
  }
}
