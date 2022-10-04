using System;
using System.Text.Json.Serialization;

namespace DMHelper.ViewModels
{
    public class EnvironmentViewModel
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public String Name { get; set; }

    }
}
