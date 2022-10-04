using Microsoft.EntityFrameworkCore;

namespace DMHelperApi.Models
{
    public class DMHelperContext : DbContext
    {
        public DMHelperContext(DbContextOptions<DMHelperContext> options)
             : base(options)
        {
        }

        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Encounter> Encounters { get; set; }

        // Database connectivity.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                     // Use option below to work with local SQL server.
            optionsBuilder.UseSqlServer(@"Server=localhost; Database=dmhelper; Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Enviroment init.
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 1, Name = "Abyssal Plane" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 2, Name = "Arctic" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 3, Name = "Celestial Plane" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 4, Name = "Coastal" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 5, Name = "Desert" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 6, Name = "Elemental Plane of Air" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 7, Name = "Elemental Plane of Earth" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 8, Name = "Elemental Plane of Fire" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 9, Name = "Elemental Plane of Water" });
            modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 10, Name = "Forest" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 11, Name = "Grassland" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 12, Name = "Hill" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 13, Name = "Infernal Plane" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 14, Name = "Jungle" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 15, Name = "Mountain" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 16, Name = "Swamp" });
            modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 17, Name = "Underdark" });
            //modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 18, Name = "Underwater" });
            modelBuilder.Entity<EnvironmentType>().HasData(new EnvironmentType { EnvironmentTypeId = 19, Name = "Urban" });

            // Monsters init.
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 1, EnvironmentTypeId = 10, Name = "Goblin", Experience = 50, Armour = 15, HitPoints = 7, Speed = 30, Attack = "Scimitar", Strength = "8 (-1)", Dexterity = "14 (+2)", Constitution = "10 (+0)", Intelligence = "10 (+0)", Wisdom = "8 (-1)", Charisma = "8 (-1)"});
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 2, EnvironmentTypeId = 10, Name = "Hydra", Experience = 900, Armour = 15, HitPoints = 172, Speed = 30, Attack = "Bite", Strength = "20 (+5)", Dexterity = "12 (+1)", Constitution = "20 (+5)", Intelligence = "2 (-4)", Wisdom = "10 (+0)", Charisma = "7 (-2)"});
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 3, EnvironmentTypeId = 10, Name = "Owlbear", Experience = 700, Armour = 13, HitPoints = 59, Speed = 40, Attack = "Beak", Strength = "20 (+5)", Dexterity = "12 (+1)", Constitution = "17 (+3)", Intelligence = "3 (-4)", Wisdom = "12 (+1)", Charisma = "7 (-2)"});
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 4, EnvironmentTypeId = 10, Name = "Nilbog", Experience = 200, Armour = 13, HitPoints = 7, Speed = 30, Attack = "Club", Strength = "8 (-1)", Dexterity = "14 (+2)", Constitution = "10 (+0)", Intelligence = "10 (+0)", Wisdom = "8 (-1)", Charisma = "15 (+2)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 5, EnvironmentTypeId = 10, Name = "Wolf", Experience = 50, Armour = 13, HitPoints = 11, Speed = 30, Attack = "Bite", Strength = "12 (+1)", Dexterity = "15 (+2)", Constitution = "12 (+1)", Intelligence = "3 (-4)", Wisdom = "12 (+1)", Charisma = "6 (-2)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 6, EnvironmentTypeId = 19, Name = "Noble", Experience = 25, Armour = 15, HitPoints = 9, Speed = 30, Attack = "Rapier", Strength = "11 (+0)", Dexterity = "12 (+1)", Constitution = "11 (+0)", Intelligence = "12 (+1)", Wisdom = "14 (+2)", Charisma = "16 (+3)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 7, EnvironmentTypeId = 19, Name = "Guard", Experience = 25, Armour = 16, HitPoints = 11, Speed = 30, Attack = "Spear", Strength = "13 (+1)", Dexterity = "12 (+1)", Constitution = "12 (+1)", Intelligence = "10 (+0)", Wisdom = "11 (+0)", Charisma = "10 (+0)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 8, EnvironmentTypeId = 19, Name = "Skeleton", Experience = 50, Armour = 13, HitPoints = 13, Speed = 30, Attack = "Shortsword", Strength = "10 (+0)", Dexterity = "14 (+2)", Constitution = "15 (+2)", Intelligence = "6 (-2)", Wisdom = "8 (-1)", Charisma = "5 (-3)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 9, EnvironmentTypeId = 17, Name = "Wight", Experience = 700, Armour = 14, HitPoints = 45, Speed = 30, Attack = "Longsword", Strength = "15 (+2)", Dexterity = "14 (+2)", Constitution = "16 (+3)", Intelligence = "10 (+0)", Wisdom = "13 (+1)", Charisma = "15 (+2)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 10, EnvironmentTypeId = 19, Name = "Meazel", Experience = 200, Armour = 13, HitPoints = 35, Speed = 30, Attack = "Shortsword", Strength = "8 (-1)", Dexterity = "17 (+3)", Constitution = "9 (-1)", Intelligence = "14 (+2)", Wisdom = "13 (+1)", Charisma = "10 (+0)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 11, EnvironmentTypeId = 10, Name = "Gnoll", Experience = 100, Armour = 15, HitPoints = 22, Speed = 30, Attack = "Spear", Strength = "14 (+2)", Dexterity = "12 (+1)", Constitution = "11 (+0)", Intelligence = "6 (-2)", Wisdom = "10 (+0)", Charisma = "7 (-2)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 12, EnvironmentTypeId = 17, Name = "Ettin", Experience = 1100, Armour = 12, HitPoints = 85, Speed = 40, Attack = "Battleaxe", Strength = "21 (+5)", Dexterity = "8 (-1)", Constitution = "17 (+3)", Intelligence = "6 (-2)", Wisdom = "10 (+0)", Charisma = "8 (-1)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 13, EnvironmentTypeId = 19, Name = "Mimic", Experience = 450, Armour = 12, HitPoints = 58, Speed = 15, Attack = "Pseudopod", Strength = "17 (+3)", Dexterity = "12 (+1)", Constitution = "15 (+2)", Intelligence = "5 (-3)", Wisdom = "13 (+1)", Charisma = "8 (-1)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 14, EnvironmentTypeId = 19, Name = "Bandit Captain", Experience = 450, Armour = 15, HitPoints = 65, Speed = 30, Attack = "Scimitar", Strength = "15 (+2)", Dexterity = "16 (+3)", Constitution = "14 (+2)", Intelligence = "14 (+2)", Wisdom = "11 (+0)", Charisma = "14 (+2)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 15, EnvironmentTypeId = 19, Name = "Bandit", Experience = 25, Armour = 12, HitPoints = 11, Speed = 30, Attack = "Scimitar", Strength = "11 (+0)", Dexterity = "12 (+1)", Constitution = "12 (+1)", Intelligence = "10 (+0)", Wisdom = "10 (+0)", Charisma = "10 (+0)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 16, EnvironmentTypeId = 17, Name = "Drow", Experience = 50, Armour = 15, HitPoints = 13, Speed = 30, Attack = "Shortsword", Strength = "10 (+0)", Dexterity = "14 (+2)", Constitution = "10 (+0)", Intelligence = "11 (+0)", Wisdom = "11 (+0)", Charisma = "12 (+1)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 17, EnvironmentTypeId = 10, Name = "Hobgoblin", Experience = 100, Armour = 18, HitPoints = 11, Speed = 30, Attack = "Longsword", Strength = "13 (+1)", Dexterity = "12 (+1)", Constitution = "12 (+1)", Intelligence = "10 (+0)", Wisdom = "10 (+0)", Charisma = "9 (-1)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 18, EnvironmentTypeId = 10, Name = "Bugbear", Experience = 200, Armour = 16, HitPoints = 27, Speed = 30, Attack = "Morningstar", Strength = "15 (+2)", Dexterity = "14 (+2)", Constitution = "13 (+1)", Intelligence = "8 (-1)", Wisdom = "11 (+0)", Charisma = "9 (-1)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 19, EnvironmentTypeId = 17, Name = "Darkling", Experience = 100, Armour = 14, HitPoints = 13, Speed = 30, Attack = "Dagger", Strength = "9 (-1)", Dexterity = "16 (+3)", Constitution = "12 (+1)", Intelligence = "10 (+0)", Wisdom = "12 (+1)", Charisma = "10 (+0)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 20, EnvironmentTypeId = 17, Name = "Derro", Experience = 50, Armour = 13, HitPoints = 13, Speed = 30, Attack = "Light Crossbow", Strength = "10 (+0)", Dexterity = "14 (+2)", Constitution = "12 (+1)", Intelligence = "11 (+0)", Wisdom = "5 (-3)", Charisma = "9 (-1)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 21, EnvironmentTypeId = 17, Name = "Kobold", Experience = 25, Armour = 12, HitPoints = 5, Speed = 30, Attack = "Dagger", Strength = "7 (-2)", Dexterity = "15 (+2)", Constitution = "9 (-1)", Intelligence = "11 (+0)", Wisdom = "7 (-2)", Charisma = "8 (-1)" });
            modelBuilder.Entity<Monster>().HasData(new Monster { MonsterId = 22, EnvironmentTypeId = 17, Name = "Orc", Experience = 100, Armour = 13, HitPoints = 15, Speed = 30, Attack = "Greataxe", Strength = "16 (+3)", Dexterity = "12 (+1)", Constitution = "16 (+3)", Intelligence = "7 (-2)", Wisdom = "11 (+0)", Charisma = "10 (+0)" });


            // Add FK for enviroment.
            modelBuilder.Entity<Monster>()
                .HasOne(e => e.Environment)
                .WithMany()
                .HasForeignKey(a => a.EnvironmentTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Encounters init.
            modelBuilder.Entity<Encounter>().HasData(new Encounter { EncounterId = 1, EnvironmentTypeId = 10, Name = "Forest encounter" });
            modelBuilder.Entity<Encounter>().HasData(new Encounter { EncounterId = 2, EnvironmentTypeId = 10, Name = "Special Swampy forest encounter" });
            modelBuilder.Entity<Encounter>().HasData(new Encounter { EncounterId = 3, EnvironmentTypeId = 10, Name = "Hard forest encounter" });

            // Add FK for enviroment.
            modelBuilder.Entity<Encounter>()
                .HasOne(e => e.Environment)
                .WithMany()
                .HasForeignKey(a => a.EnvironmentTypeId)
                .OnDelete(DeleteBehavior.Restrict);


            // MonsterEncounter init (many to many relationship between encounters and monsters).
            modelBuilder.Entity<MonsterEncounter>().HasData(new MonsterEncounter { EncounterId = 1, MonsterId = 1, Amount = 2 });
            modelBuilder.Entity<MonsterEncounter>().HasData(new MonsterEncounter { EncounterId = 2, MonsterId = 2, Amount = 1 });
            modelBuilder.Entity<MonsterEncounter>().HasData(new MonsterEncounter { EncounterId = 3, MonsterId = 1, Amount = 1 });
            modelBuilder.Entity<MonsterEncounter>().HasData(new MonsterEncounter { EncounterId = 3, MonsterId = 3, Amount = 1 });

            // Add keys for encounter and monster.
            modelBuilder.Entity<MonsterEncounter>()
                .HasKey(bc => new { bc.EncounterId, bc.MonsterId });

            // Set amount default to 1.
            modelBuilder.Entity<MonsterEncounter>()
                .Property(pt => pt.Amount).HasDefaultValue(1);

            // Add relationship for monsters.
            modelBuilder.Entity<MonsterEncounter>()
                        .HasOne(pt => pt.Monster)
                        .WithMany(t => t.MonsterEncounters)
                        .HasForeignKey(pt => pt.MonsterId);

            // Add relationship for encounters.
            modelBuilder.Entity<MonsterEncounter>()
                        .HasOne(pt => pt.Encounter)
                        .WithMany(p => p.MonsterEncounters)
                        .HasForeignKey(pt => pt.EncounterId);
        }
    }
}
