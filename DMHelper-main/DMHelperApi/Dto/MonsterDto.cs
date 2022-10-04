namespace DMHelperApi.ViewModels
{
    public class MonsterDto
    {
        public int Id { get; set; }
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
        public int Amount { get; set; }
        public int EnvironmentTypeId { get; set; }
        public EnvironmentDto Environment { get; set; }
    }
}
