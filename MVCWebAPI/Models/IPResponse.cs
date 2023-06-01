using System.Text.Json.Serialization;


namespace MvcWebApi.Models
{

    public class IPResponse
    {
        [JsonPropertyName("ip")]
        public string IP { get; set; }
    }



}



