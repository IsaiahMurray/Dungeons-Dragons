using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1.Character.Skills.SkillList;

namespace ClassLibrary1.Character.CharacterClasses
{
    public class Barbarian
    {
        private Character character;
        public int HitPoints { get; private set; }
        public List<string> Proficiencies { get; private set; }
        public List<Skill> Skills { get; private set; }
        public List<string> Equipment { get; private set; }
        public int Rages { get; private set; }

        public Barbarian(){}

        public void LevelUp()
        {
            // Adjust properties based on Barbarian level
            UpdateHitPoints();
            UpdateRages();
            // Add more updates for new features at higher levels
        }

        private void UpdateHitPoints()
        {
            // Adjust HitPoints based on Barbarian level
            // 1d12 (or 7) + Constitution modifier per barbarian level after 1st
        }

        private void UpdateRages()
        {
            // Adjust the number of rages based on Barbarian level
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Barbarian Level: {BarbarianLevel}");
            Console.WriteLine($"Hit Points: {HitPoints}");
            Console.WriteLine("Proficiencies:");
            foreach (var proficiency in Proficiencies)
            {
                Console.WriteLine($"   {proficiency}");
            }
            Console.WriteLine("Skills:");
            foreach (var skill in Skills)
            {
                Console.WriteLine($"   {skill}");
            }
            Console.WriteLine("Equipment:");
            foreach (var item in Equipment)
            {
                Console.WriteLine($"   {item}");
            }
            Console.WriteLine($"Number of Rages: {Rages}");
        }

        // Add methods for other features at different levels
    }

    public class BarbarianFeatures
    {
        public static void Main()
        {
            Barbarian barbarian = new Barbarian();
            barbarian.DisplayDetails();

            // Level up and display updated details
            barbarian.LevelUp();
            barbarian.DisplayDetails();
        }
    }
}
