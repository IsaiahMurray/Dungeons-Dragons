using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Gameplay;

namespace ClassLibrary1.Character.Spells
{
    public enum SpellSchool
    {
        Abjuration,
        Conjuration,
        Divination,
        Enchantment,
        Evocation,
        Illusion,
        Necromancy,
        Transmutation
    }
    public class Spell
    {
        // Properties
        public string Name { get; set; }
        public int Level { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public string CastingTime { get; set; }
        public string Range { get; set; }
        public List<SpellComponent> Components { get; set; }
        public string Duration { get; set; }
        public DamageDice Damage { get; set; }
        public Dictionary<int, DamageDice> HigherLevelDamage { get; set; }
        public List<string> SpellLists { get; set; }
        public SpellSchool School { get; set; } // Enum property for the school of magic


        // Constructor
        public Spell(
        string name, int level, string description, string source,
        string castingTime, string range, List<SpellComponent> components,
        string duration, DamageDice damage, Dictionary<int, DamageDice> higherLevelDamage,
        List<string> spellLists, SpellSchool school)
        {
            Name = name;
            Level = level;
            Description = description;
            Source = source;
            CastingTime = castingTime;
            Range = range;
            Components = components;
            Duration = duration;
            Damage = damage;
            HigherLevelDamage = higherLevelDamage;
            SpellLists = spellLists;
            School = school;
        }

        // Method to cast the spell
        public void Cast()
        {
            Console.WriteLine($"Casting {Name}!");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Source: {Source}");
            Console.WriteLine($"Casting Time: {CastingTime}");
            Console.WriteLine($"Range: {Range}");
             Console.WriteLine($"Components: {GetComponentsString()}");
            Console.WriteLine($"Duration: {Duration}");
            Console.WriteLine($"Damage Amount: {RollDamage(Damage)}");

            if (HigherLevelDamage != null && HigherLevelDamage.Count > 0)
            {
                Console.WriteLine("Higher Level Damage:");
                foreach (var kvp in HigherLevelDamage)
                {
                    Console.WriteLine($"   Level {kvp.Key}: {RollDamage(kvp.Value)}");
                }
            }

            Console.WriteLine($"Spell Lists: {string.Join(", ", SpellLists)}");
            // Add more logic as needed
        }

        // Method to roll damage based on the given dice damage configuration
        private int RollDamage(DamageDice diceDamage)
        {
            return DiceRoller.Roll(diceDamage.NumberOfDice, diceDamage.NumberOfSides, diceDamage.Modifier);
        }

        // Method to get a string representation of spell components
        private string GetComponentsString()
        {
            return string.Join(", ", Components);
        }
    }

    public class SpellComponent
    {
        public string Name { get; set; }

        public SpellComponent(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
