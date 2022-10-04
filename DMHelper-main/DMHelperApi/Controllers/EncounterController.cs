using DMHelperApi.Models;
using DMHelperApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DMHelperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncounterController : Controller
    {
        private readonly DMHelperContext _context;

        public EncounterController(DMHelperContext context)
        {
            _context = context;
        }

        // GET: api/Encounter
        [HttpGet]
        public async Task<ActionResult<List<EncounterDto>>> GetEncounters()
        {

            // Find all encounters in the DB.
            var dbEncounters = await _context.Encounters.Include(me => me.MonsterEncounters).ThenInclude(m => m.Monster).Include(e => e.Environment).OrderBy(n => n.Name).ToListAsync();

            

            // Create a new list for the encounters.
            List<EncounterDto> encounters = new List<EncounterDto>();

            // Foreach encounter convert the db information into viewmodels for the api to send to the client.
            foreach (var dbEncounter in dbEncounters)
            {
                EncounterDto encounter = new EncounterDto();

                encounter.Id = dbEncounter.EncounterId;
                encounter.Name = dbEncounter.Name;

                // Add enviroment info.
                EnvironmentDto environment = new EnvironmentDto();
                environment.Id = dbEncounter.Environment.EnvironmentTypeId;
                environment.Name = dbEncounter.Environment.Name;

                encounter.Environment = environment;


                // Add monsters info.
                List<MonsterDto> monsters = new List<MonsterDto>();
                foreach (var dbMonster in dbEncounter.MonsterEncounters)
                {
                    MonsterDto monster = new MonsterDto();

                    monster.Id = dbMonster.MonsterId;
                    monster.Name = dbMonster.Monster.Name;
                    monster.Experience = dbMonster.Monster.Experience;
                    monster.Armour = dbMonster.Monster.Armour;
                    monster.HitPoints = dbMonster.Monster.HitPoints;
                    monster.Speed = dbMonster.Monster.Speed;
                    monster.Attack = dbMonster.Monster.Attack;
                    monster.Strength = dbMonster.Monster.Strength;
                    monster.Dexterity = dbMonster.Monster.Dexterity;
                    monster.Constitution = dbMonster.Monster.Constitution;
                    monster.Intelligence = dbMonster.Monster.Intelligence;
                    monster.Wisdom = dbMonster.Monster.Wisdom;
                    monster.Charisma = dbMonster.Monster.Charisma;


                    monster.Environment = environment;

                    monster.Amount = dbMonster.Amount;

                    monsters.Add(monster);
                }

                encounter.Monsters = monsters;

                encounters.Add(encounter);
            }

            return encounters;

        }

        // GET: api/Encounter/1
        [HttpGet("{id}")]
        public async Task<ActionResult<EncounterDto>> GetEncounter(int id)
        {

            // Find single encounter in the DB
            var dbEncounter = await _context.Encounters.Include(me => me.MonsterEncounters).ThenInclude(m => m.Monster).Include(e => e.Environment).FirstOrDefaultAsync(i => i.EncounterId == id);

            if (dbEncounter == null)
            {
                return NotFound();
            }

            EncounterDto encounter = new EncounterDto();

            encounter.Name = dbEncounter.Name;
            encounter.Id = dbEncounter.EncounterId;

            EnvironmentDto environment = new EnvironmentDto();
            environment.Id = dbEncounter.Environment.EnvironmentTypeId;
            environment.Name = dbEncounter.Environment.Name;

            encounter.Environment = environment;

            List<MonsterDto> monsters = new List<MonsterDto>();
            foreach (var dbMonster in dbEncounter.MonsterEncounters)
            {
                MonsterDto monster = new MonsterDto();

                monster.Id = dbMonster.MonsterId;
                monster.Name = dbMonster.Monster.Name;
                monster.Experience = dbMonster.Monster.Experience;
                monster.Armour = dbMonster.Monster.Armour;
                monster.HitPoints = dbMonster.Monster.HitPoints;
                monster.Speed = dbMonster.Monster.Speed;
                monster.Attack = dbMonster.Monster.Attack;
                monster.Strength = dbMonster.Monster.Strength;
                monster.Dexterity = dbMonster.Monster.Dexterity;
                monster.Constitution = dbMonster.Monster.Constitution;
                monster.Intelligence = dbMonster.Monster.Intelligence;
                monster.Wisdom = dbMonster.Monster.Wisdom;
                monster.Charisma = dbMonster.Monster.Charisma;

                monster.Environment = environment;
                monster.Amount = dbMonster.Amount;

                monsters.Add(monster);
            }

            encounter.Monsters = monsters;



            return encounter;

        }

        // PUT: api/Encounter/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonster(int id, EncounterDto encounter)
        {

            // Find encounter in DB that is to be changed.
            var dbEncounter = _context.Encounters.FirstOrDefault(i => i.EncounterId == id);
            if (dbEncounter == null)
            {
                return NotFound();
            }

            // Change values.
            dbEncounter.Name = encounter.Name;

            // Save changes.
            await _context.SaveChangesAsync();

            return NoContent();
        }


        // POST: api/Encounter
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Encounter>> PostEncounter(EncounterDto encounter)
        {
            // Encounter is supplied as Dto. Needs to be converted to object and saved to DB.
            // EF Core does a lot of stuff for free. Only required variables are given value in method logic.

            // Encounter base for new encounter.
            Encounter newEncounter = new Encounter();

            // Assigning value to variables of new encounter.
            newEncounter.Name = encounter.Name;
            newEncounter.EnvironmentTypeId = encounter.Environment.Id;

            // Because each encounter has a many to many relationship to monsters. Relation is defined and EF Core figures out how to connect things in the DB.
            List<MonsterEncounter> monsterEncounter = new List<MonsterEncounter>();
            foreach (var m in encounter.Monsters)
            {
                MonsterEncounter newMonsterEncounter = new MonsterEncounter();

                newMonsterEncounter.MonsterId = m.Id;
                newMonsterEncounter.Amount = m.Amount;

                monsterEncounter.Add(newMonsterEncounter);
            }

            newEncounter.MonsterEncounters = monsterEncounter;

            _context.Encounters.Add(newEncounter);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
           // return CreatedAtAction(nameof(PostEncounter), new { id = newEncounter.EncounterId }, newEncounter);
            return Ok();
        }


        // DELETE: api/Encounter/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEncounter(int id)
        {
            // Find the envounter to delete in DB based on id.
            var encounter = await _context.Encounters.FindAsync(id);
            if (encounter == null)
            {
                return NotFound();
            }

            // Remove if found and save the change.
            _context.Encounters.Remove(encounter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        
    }
}
