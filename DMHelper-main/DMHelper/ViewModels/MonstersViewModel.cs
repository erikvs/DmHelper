using System.Text.Json.Serialization;
using CommunityToolkit.Mvvm.ComponentModel;


namespace DMHelper.ViewModels
{
    public class MonstersViewModel : ObservableRecipient
    {
        public MonstersViewModel()
        {
        }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("experience")]
        public int Experience { get; set; }

        [JsonPropertyName("armour")]
        public int Armour { get; set; }

        [JsonPropertyName("hitPoints")]
        public int HitPoints { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("attack")]
        public string Attack { get; set; }

        [JsonPropertyName("strength")]
        public string Strength { get; set; }

        [JsonPropertyName("dexterity")]
        public string Dexterity { get; set; }

        [JsonPropertyName("constitution")]
        public string Constitution { get; set; }

        [JsonPropertyName("intelligence")]
        public string Intelligence { get; set; }

        [JsonPropertyName("wisdom")]
        public string Wisdom { get; set; }

        [JsonPropertyName("charisma")]
        public string Charisma { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }
        
        [JsonPropertyName("environmenttypeid")]
        public int EnvironmentTypeId { get; set; }

        [JsonPropertyName("environment")]
        public EnvironmentViewModel Environment { get; set; }

    }
}
