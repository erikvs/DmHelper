using System.Collections.Generic;

namespace DMHelperApi.Models
{
    public class Monster
    {
        public int MonsterId { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Armour { get; set; }
        public int HitPoints { get; set; }
        public int Speed { get; set; }
        public string Attack { get; set; }
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }
        public int EnvironmentTypeId { get; set; }
        public EnvironmentType Environment { get; set; }
        public ICollection<MonsterEncounter> MonsterEncounters { get; set; }
    }

    public class Encounter
    {
        public int EncounterId { get; set; }
        public string Name { get; set; }
        public int EnvironmentTypeId { get; set; }
        public EnvironmentType Environment { get; set; }
        public ICollection<MonsterEncounter> MonsterEncounters { get; set; }
    }

    public class MonsterEncounter
    {
        public int Amount { get; set; }
        public int MonsterId { get; set; }
        public Monster Monster { get; set; }
        public int EncounterId { get; set; }
        public Encounter Encounter { get; set; }
    }

    public class EnvironmentType
    {
        public int EnvironmentTypeId { get; set; }
        public string Name { get; set; }
    }
}
