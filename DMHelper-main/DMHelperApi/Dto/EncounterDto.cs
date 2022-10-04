using System.Collections.Generic;

namespace DMHelperApi.ViewModels
{
    public class EncounterDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public EnvironmentDto Environment { get; set; }

        public List<MonsterDto> Monsters { get; set; }

    }
}
