using DMHelperApi.Models;
using DMHelperApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMHelperApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MonsterController : Controller
    {
        private readonly DMHelperContext _context;

        public MonsterController(DMHelperContext context)
        {
            _context = context;
        }

        // GET: api/Monster
        [HttpGet]
        public async Task<ActionResult<List<MonsterDto>>> GetMonsters()
        {

            // Find all monsters in the DB.
            var dbMonsters = await _context.Monsters.Include(e => e.Environment).OrderBy(n => n.Name).ToListAsync();

            // Create a new list for the monsters.
            List<MonsterDto> monsters = new List<MonsterDto>();

            // Foreach monster convert the db information into viewmodels for the api to send to the client.
            foreach (var dbMonster in dbMonsters)
            {
                MonsterDto monster = new MonsterDto();

                monster.Id = dbMonster.MonsterId;
                monster.Name = dbMonster.Name;
                monster.Experience = dbMonster.Experience;
                monster.Armour = dbMonster.Armour;
                monster.HitPoints = dbMonster.HitPoints;
                monster.Speed = dbMonster.Speed;
                monster.Attack = dbMonster.Attack;
                monster.Strength = dbMonster.Strength;
                monster.Dexterity = dbMonster.Dexterity;
                monster.Constitution = dbMonster.Constitution;
                monster.Intelligence = dbMonster.Intelligence;
                monster.Wisdom = dbMonster.Wisdom;
                monster.Charisma = dbMonster.Charisma;

                // Add enviroment info.
                EnvironmentDto environment = new EnvironmentDto();
                environment.Id = dbMonster.Environment.EnvironmentTypeId;
                environment.Name = dbMonster.Environment.Name;

                monster.Environment = environment;

                monsters.Add(monster);
            }

            return monsters;
        }

        // GET: api/Monster/1
        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterDto>> GetMonster(int id)
        {

            // Find single monster in the DB.
            var dbMonster = await _context.Monsters.Include(e => e.Environment).FirstOrDefaultAsync(i => i.MonsterId == id);

            if (dbMonster == null)
            {
                return NotFound();
            }

            MonsterDto monster = new MonsterDto();

            monster.Id = dbMonster.MonsterId;
            monster.Name = dbMonster.Name;
            monster.Experience = dbMonster.Experience;
            monster.Armour = dbMonster.Armour;
            monster.HitPoints = dbMonster.HitPoints;
            monster.Speed = dbMonster.Speed;
            monster.Attack = dbMonster.Attack;
            monster.Strength = dbMonster.Strength;
            monster.Dexterity = dbMonster.Dexterity;
            monster.Constitution = dbMonster.Constitution;
            monster.Intelligence = dbMonster.Intelligence;
            monster.Wisdom = dbMonster.Wisdom;
            monster.Charisma = dbMonster.Charisma;


            // Add enviroment info.
            EnvironmentDto environment = new EnvironmentDto();
            environment.Id = dbMonster.Environment.EnvironmentTypeId;
            environment.Name = dbMonster.Environment.Name;

            monster.Environment = environment;

            return monster;
        }

        // PUT: api/Monster/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonster(int id, MonsterDto monster)
        {

            // Find monster in DB that is to be changed.
            var dbMonster = _context.Monsters.Include(e => e.Environment).FirstOrDefault(i => i.MonsterId == id);
            if (dbMonster == null)
            {
                return NotFound();
            }


            // Change values.
            dbMonster.Name = monster.Name;
            dbMonster.Experience = monster.Experience;
            dbMonster.Armour = monster.Armour;
            dbMonster.HitPoints = monster.HitPoints;
            dbMonster.Speed = monster.Speed;
            dbMonster.Attack = monster.Attack;
            dbMonster.Strength = monster.Strength;
            dbMonster.Dexterity = monster.Dexterity;
            dbMonster.Constitution = monster.Constitution;
            dbMonster.Intelligence = monster.Intelligence;
            dbMonster.Wisdom = monster.Wisdom;
            dbMonster.Charisma = monster.Charisma;

            dbMonster.EnvironmentTypeId = monster.Environment.Id;

            // Save changes.
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Monster
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Monster>> PostMonster(MonsterDto monster)
        {
            // Monster is supplied as Dto. Needs to be converted to object and saved to DB.
            // EF Core does a lot of stuff for free. Only required variables are given value in method logic.

            // Monster base for new monster.
            Monster newMonster = new Monster();
            

            // Assigning value to variables of new monster.
            newMonster.Name = monster.Name;
            newMonster.Experience = monster.Experience;
            newMonster.Armour = monster.Armour;
            newMonster.HitPoints = monster.HitPoints;
            newMonster.Speed = monster.Speed;
            newMonster.Attack = monster.Attack;
            newMonster.Strength = monster.Strength;
            newMonster.Dexterity = monster.Dexterity;
            newMonster.Constitution = monster.Constitution;
            newMonster.Intelligence = monster.Intelligence;
            newMonster.Wisdom = monster.Wisdom;
            newMonster.Charisma = monster.Charisma;

            newMonster.EnvironmentTypeId = monster.EnvironmentTypeId;

            _context.Monsters.Add(newMonster);
            await _context.SaveChangesAsync();

            return Ok();
        }


        // DELETE: api/Monster/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMonster(int id)
        {
            // Find the monster to delete in DB based on id.
            var monster = await _context.Monsters.FindAsync(id);
            if (monster == null)
            {
                return NotFound();
            }

            // Remove if found and save the change.
            _context.Monsters.Remove(monster);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MonsterExists(int id)
        {
            return _context.Monsters.Any(e => e.MonsterId == id);
        }
    }

}