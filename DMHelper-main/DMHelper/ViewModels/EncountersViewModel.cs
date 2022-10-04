using System.Collections.Generic;
using System.Text.Json.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DMHelper.ViewModels
{
    public class EncountersViewModel : ObservableRecipient
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("environment")]
        public EnvironmentViewModel Environment { get; set; }

        [JsonPropertyName("monsters")]
        public List<MonstersViewModel> Monsters { get; set; }
    }
}
