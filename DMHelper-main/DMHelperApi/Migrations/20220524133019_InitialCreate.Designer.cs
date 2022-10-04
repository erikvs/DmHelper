﻿// <auto-generated />
using DMHelperApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DMHelperApi.Migrations
{
    [DbContext(typeof(DMHelperContext))]
    [Migration("20220524133019_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DMHelperApi.Models.Encounter", b =>
                {
                    b.Property<int>("EncounterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnvironmentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EncounterId");

                    b.HasIndex("EnvironmentTypeId");

                    b.ToTable("Encounters");

                    b.HasData(
                        new
                        {
                            EncounterId = 1,
                            EnvironmentTypeId = 10,
                            Name = "Forest encounter"
                        },
                        new
                        {
                            EncounterId = 2,
                            EnvironmentTypeId = 10,
                            Name = "Special Swampy forest encounter"
                        },
                        new
                        {
                            EncounterId = 3,
                            EnvironmentTypeId = 10,
                            Name = "Hard forest encounter"
                        });
                });

            modelBuilder.Entity("DMHelperApi.Models.EnvironmentType", b =>
                {
                    b.Property<int>("EnvironmentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnvironmentTypeId");

                    b.ToTable("EnvironmentType");

                    b.HasData(
                        new
                        {
                            EnvironmentTypeId = 10,
                            Name = "Forest"
                        },
                        new
                        {
                            EnvironmentTypeId = 17,
                            Name = "Underdark"
                        },
                        new
                        {
                            EnvironmentTypeId = 19,
                            Name = "Urban"
                        });
                });

            modelBuilder.Entity("DMHelperApi.Models.Monster", b =>
                {
                    b.Property<int>("MonsterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Armour")
                        .HasColumnType("int");

                    b.Property<string>("Attack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Charisma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Constitution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dexterity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnvironmentTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<int>("HitPoints")
                        .HasColumnType("int");

                    b.Property<string>("Intelligence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<string>("Strength")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wisdom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MonsterId");

                    b.HasIndex("EnvironmentTypeId");

                    b.ToTable("Monsters");

                    b.HasData(
                        new
                        {
                            MonsterId = 1,
                            Armour = 15,
                            Attack = "Scimitar",
                            Charisma = "8 (-1)",
                            Constitution = "10 (+0)",
                            Dexterity = "14 (+2)",
                            EnvironmentTypeId = 10,
                            Experience = 50,
                            HitPoints = 7,
                            Intelligence = "10 (+0)",
                            Name = "Goblin",
                            Speed = 30,
                            Strength = "8 (-1)",
                            Wisdom = "8 (-1)"
                        },
                        new
                        {
                            MonsterId = 2,
                            Armour = 15,
                            Attack = "Bite",
                            Charisma = "7 (-2)",
                            Constitution = "20 (+5)",
                            Dexterity = "12 (+1)",
                            EnvironmentTypeId = 10,
                            Experience = 900,
                            HitPoints = 172,
                            Intelligence = "2 (-4)",
                            Name = "Hydra",
                            Speed = 30,
                            Strength = "20 (+5)",
                            Wisdom = "10 (+0)"
                        },
                        new
                        {
                            MonsterId = 3,
                            Armour = 13,
                            Attack = "Beak",
                            Charisma = "7 (-2)",
                            Constitution = "17 (+3)",
                            Dexterity = "12 (+1)",
                            EnvironmentTypeId = 10,
                            Experience = 700,
                            HitPoints = 59,
                            Intelligence = "3 (-4)",
                            Name = "Owlbear",
                            Speed = 40,
                            Strength = "20 (+5)",
                            Wisdom = "12 (+1)"
                        },
                        new
                        {
                            MonsterId = 4,
                            Armour = 13,
                            Attack = "Club",
                            Charisma = "15 (+2)",
                            Constitution = "10 (+0)",
                            Dexterity = "14 (+2)",
                            EnvironmentTypeId = 10,
                            Experience = 200,
                            HitPoints = 7,
                            Intelligence = "10 (+0)",
                            Name = "Nilbog",
                            Speed = 30,
                            Strength = "8 (-1)",
                            Wisdom = "8 (-1)"
                        },
                        new
                        {
                            MonsterId = 5,
                            Armour = 13,
                            Attack = "Bite",
                            Charisma = "6 (-2)",
                            Constitution = "12 (+1)",
                            Dexterity = "15 (+2)",
                            EnvironmentTypeId = 10,
                            Experience = 50,
                            HitPoints = 11,
                            Intelligence = "3 (-4)",
                            Name = "Wolf",
                            Speed = 30,
                            Strength = "12 (+1)",
                            Wisdom = "12 (+1)"
                        },
                        new
                        {
                            MonsterId = 6,
                            Armour = 15,
                            Attack = "Rapier",
                            Charisma = "16 (+3)",
                            Constitution = "11 (+0)",
                            Dexterity = "12 (+1)",
                            EnvironmentTypeId = 19,
                            Experience = 25,
                            HitPoints = 9,
                            Intelligence = "12 (+1)",
                            Name = "Noble",
                            Speed = 30,
                            Strength = "11 (+0)",
                            Wisdom = "14 (+2)"
                        },
                        new
                        {
                            MonsterId = 7,
                            Armour = 16,
                            Attack = "Spear",
                            Charisma = "10 (+0)",
                            Constitution = "12 (+1)",
                            Dexterity = "12 (+1)",
                            EnvironmentTypeId = 19,
                            Experience = 25,
                            HitPoints = 11,
                            Intelligence = "10 (+0)",
                            Name = "Guard",
                            Speed = 30,
                            Strength = "13 (+1)",
                            Wisdom = "11 (+0)"
                        },
                        new
                        {
                            MonsterId = 8,
                            Armour = 13,
                            Attack = "Shortsword",
                            Charisma = "5 (-3)",
                            Constitution = "15 (+2)",
                            Dexterity = "14 (+2)",
                            EnvironmentTypeId = 19,
                            Experience = 50,
                            HitPoints = 13,
                            Intelligence = "6 (-2)",
                            Name = "Skeleton",
                            Speed = 30,
                            Strength = "10 (+0)",
                            Wisdom = "8 (-1)"
                        },
                        new
                        {
                            MonsterId = 9,
                            Armour = 14,
                            Attack = "Longsword",
                            Charisma = "15 (+2)",
                            Constitution = "16 (+3)",
                            Dexterity = "14 (+2)",
                            EnvironmentTypeId = 17,
                            Experience = 700,
                            HitPoints = 45,
                            Intelligence = "10 (+0)",
                            Name = "Wight",
                            Speed = 30,
                            Strength = "15 (+2)",
                            Wisdom = "13 (+1)"
                        },
                        new
                        {
                            MonsterId = 10,
                            Armour = 13,
                            Attack = "Shortsword",
                            Charisma = "10 (+0)",
                            Constitution = "9 (-1)",
                            Dexterity = "17 (+3)",
                            EnvironmentTypeId = 19,
                            Experience = 200,
                            HitPoints = 35,
                            Intelligence = "14 (+2)",
                            Name = "Meazel",
                            Speed = 30,
                            Strength = "8 (-1)",
                            Wisdom = "13 (+1)"
                        },
                        new
                        {
                            MonsterId = 11,
                            Armour = 15,
                            Attack = "Spear",
                            Charisma = "7 (-2)",
                            Constitution = "11 (+0)",
                            Dexterity = "12 (+1)",
                            EnvironmentTypeId = 10,
                            Experience = 100,
                            HitPoints = 22,
                            Intelligence = "6 (-2)",
                            Name = "Gnoll",
                            Speed = 30,
                            Strength = "14 (+2)",
                            Wisdom = "10 (+0)"
                        },
                        new
                        {
                            MonsterId = 12,
                            Armour = 12,
                            Attack = "Battleaxe",
                            Charisma = "8 (-1)",
                            Constitution = "17 (+3)",
                            Dexterity = "8 (-1)",
                            EnvironmentTypeId = 17,
                            Experience = 1100,
                            HitPoints = 85,
                            Intelligence = "6 (-2)",
                            Name = "Ettin",
                            Speed = 40,
                            Strength = "21 (+5)",
                            Wisdom = "10 (+0)"
                        },
                        new
                        {
                            MonsterId = 13,
                            Armour = 12,
                            Attack = "Pseudopod",
                            Charisma = "8 (-1)",
                            Constitution = "15 (+2)",
                            Dexterity = "12 (+1)",
                            EnvironmentTypeId = 19,
                            Experience = 450,
                            HitPoints = 58,
                            Intelligence = "5 (-3)",
                            Name = "Mimic",
                            Speed = 15,
                            Strength = "17 (+3)",
                            Wisdom = "13 (+1)"
                        },
                        new
                        {
                            MonsterId = 14,
                            Armour = 15,
                            Attack = "Scimitar",
                            Charisma = "14 (+2)",
                            Constitution = "14 (+2)",
                            Dexterity = "16 (+3)",
                            EnvironmentTypeId = 19,
                            Experience = 450,
                            HitPoints = 65,
                            Intelligence = "14 (+2)",
                            Name = "Bandit Captain",
                            Speed = 30,
                            Strength = "15 (+2)",
                            Wisdom = "11 (+0)"
                        },
                        new
                        {
                            MonsterId = 15,
                            Armour = 12,
                            Attack = "Scimitar",
                            Charisma = "10 (+0)",
                            Constitution = "12 (+1)",
                            Dexterity = "12 (+1)",
                            EnvironmentTypeId = 19,
                            Experience = 25,
                            HitPoints = 11,
                            Intelligence = "10 (+0)",
                            Name = "Bandit",
                            Speed = 30,
                            Strength = "11 (+0)",
                            Wisdom = "10 (+0)"
                        },
                        new
                        {
                            MonsterId = 16,
                            Armour = 15,
                            Attack = "Shortsword",
                            Charisma = "12 (+1)",
                            Constitution = "10 (+0)",
                            Dexterity = "14 (+2)",
                            EnvironmentTypeId = 17,
                            Experience = 50,
                            HitPoints = 13,
                            Intelligence = "11 (+0)",
                            Name = "Drow",
                            Speed = 30,
                            Strength = "10 (+0)",
                            Wisdom = "11 (+0)"
                        },
                        new
                        {
                            MonsterId = 17,
                            Armour = 18,
                            Attack = "Longsword",
                            Charisma = "9 (-1)",
                            Constitution = "12 (+1)",
                            Dexterity = "12 (+1)",
                            EnvironmentTypeId = 10,
                            Experience = 100,
                            HitPoints = 11,
                            Intelligence = "10 (+0)",
                            Name = "Hobgoblin",
                            Speed = 30,
                            Strength = "13 (+1)",
                            Wisdom = "10 (+0)"
                        },
                        new
                        {
                            MonsterId = 18,
                            Armour = 16,
                            Attack = "Morningstar",
                            Charisma = "9 (-1)",
                            Constitution = "13 (+1)",
                            Dexterity = "14 (+2)",
                            EnvironmentTypeId = 10,
                            Experience = 200,
                            HitPoints = 27,
                            Intelligence = "8 (-1)",
                            Name = "Bugbear",
                            Speed = 30,
                            Strength = "15 (+2)",
                            Wisdom = "11 (+0)"
                        },
                        new
                        {
                            MonsterId = 19,
                            Armour = 14,
                            Attack = "Dagger",
                            Charisma = "10 (+0)",
                            Constitution = "12 (+1)",
                            Dexterity = "16 (+3)",
                            EnvironmentTypeId = 17,
                            Experience = 100,
                            HitPoints = 13,
                            Intelligence = "10 (+0)",
                            Name = "Darkling",
                            Speed = 30,
                            Strength = "9 (-1)",
                            Wisdom = "12 (+1)"
                        },
                        new
                        {
                            MonsterId = 20,
                            Armour = 13,
                            Attack = "Light Crossbow",
                            Charisma = "9 (-1)",
                            Constitution = "12 (+1)",
                            Dexterity = "14 (+2)",
                            EnvironmentTypeId = 17,
                            Experience = 50,
                            HitPoints = 13,
                            Intelligence = "11 (+0)",
                            Name = "Derro",
                            Speed = 30,
                            Strength = "10 (+0)",
                            Wisdom = "5 (-3)"
                        },
                        new
                        {
                            MonsterId = 21,
                            Armour = 12,
                            Attack = "Dagger",
                            Charisma = "8 (-1)",
                            Constitution = "9 (-1)",
                            Dexterity = "15 (+2)",
                            EnvironmentTypeId = 17,
                            Experience = 25,
                            HitPoints = 5,
                            Intelligence = "11 (+0)",
                            Name = "Kobold",
                            Speed = 30,
                            Strength = "7 (-2)",
                            Wisdom = "7 (-2)"
                        },
                        new
                        {
                            MonsterId = 22,
                            Armour = 13,
                            Attack = "Greataxe",
                            Charisma = "10 (+0)",
                            Constitution = "16 (+3)",
                            Dexterity = "12 (+1)",
                            EnvironmentTypeId = 17,
                            Experience = 100,
                            HitPoints = 15,
                            Intelligence = "7 (-2)",
                            Name = "Orc",
                            Speed = 30,
                            Strength = "16 (+3)",
                            Wisdom = "11 (+0)"
                        });
                });

            modelBuilder.Entity("DMHelperApi.Models.MonsterEncounter", b =>
                {
                    b.Property<int>("EncounterId")
                        .HasColumnType("int");

                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("EncounterId", "MonsterId");

                    b.HasIndex("MonsterId");

                    b.ToTable("MonsterEncounter");

                    b.HasData(
                        new
                        {
                            EncounterId = 1,
                            MonsterId = 1,
                            Amount = 2
                        },
                        new
                        {
                            EncounterId = 2,
                            MonsterId = 2,
                            Amount = 1
                        },
                        new
                        {
                            EncounterId = 3,
                            MonsterId = 1,
                            Amount = 1
                        },
                        new
                        {
                            EncounterId = 3,
                            MonsterId = 3,
                            Amount = 1
                        });
                });

            modelBuilder.Entity("DMHelperApi.Models.Encounter", b =>
                {
                    b.HasOne("DMHelperApi.Models.EnvironmentType", "Environment")
                        .WithMany()
                        .HasForeignKey("EnvironmentTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Environment");
                });

            modelBuilder.Entity("DMHelperApi.Models.Monster", b =>
                {
                    b.HasOne("DMHelperApi.Models.EnvironmentType", "Environment")
                        .WithMany()
                        .HasForeignKey("EnvironmentTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Environment");
                });

            modelBuilder.Entity("DMHelperApi.Models.MonsterEncounter", b =>
                {
                    b.HasOne("DMHelperApi.Models.Encounter", "Encounter")
                        .WithMany("MonsterEncounters")
                        .HasForeignKey("EncounterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMHelperApi.Models.Monster", "Monster")
                        .WithMany("MonsterEncounters")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Encounter");

                    b.Navigation("Monster");
                });

            modelBuilder.Entity("DMHelperApi.Models.Encounter", b =>
                {
                    b.Navigation("MonsterEncounters");
                });

            modelBuilder.Entity("DMHelperApi.Models.Monster", b =>
                {
                    b.Navigation("MonsterEncounters");
                });
#pragma warning restore 612, 618
        }
    }
}
