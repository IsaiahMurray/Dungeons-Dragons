using ClassLibrary1.Character.Backgrounds;
using ClassLibrary1.Character.CharacterClass;
using ClassLibrary1.Character.Equipment;
using ClassLibrary1.Character.Spells;
using ClassLibrary1.Character.Traits;
using static ClassLibrary1.Character.Skills.SkillList;
using ClassLibrary1.Character.CharacterClasses;

namespace ClassLibrary1.Character
{
    public enum Size { Tiny, Small, Medium, Large, Huge, Gargantuan }
    public enum ArmorClass { Light, Medium, Heavy }
    public enum Alignment { Lawful_Good, Lawful_Neutral, Lawful_Evil, Chaotic_Good, Chaotic_Neutral, Chaotic_Evil, Neutral_Good, True_Neutral, Neutral_Evil }
    public class Character
    {
        public Character() { }
        public Character(string name, int level, Alignment alignment, Race race, Size size, int speed,
                    ArmorClass armorClass, int initiative, int currentHitPoints, int tempHitPoints,
                    int proficiencyBonus, CharacterStats stats, List<Skill> skills, List<Spell> spells)
        {
            Name = name;
            Level = level;
            Alignment = alignment;
            Race = race;
            Size = size;
            Speed = speed;
            ArmorClass = armorClass;
            Initiative = initiative;
            CurrentHitPoints = currentHitPoints;
            TempHitPoints = tempHitPoints;
            ProficiencyBonus = proficiencyBonus;
            Stats = stats;
            Skills = skills;
            Spells = spells;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public Alignment Alignment { get; set; }
        public Race Race { get; set; }
        public Size Size { get; set; }  
        public int Speed { get; set; }
        public ArmorClass ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int CurrentHitPoints { get; set; }
        public int TempHitPoints { get; set; }
        //public CharacterClass Class { get; set; }
        public int ProficiencyBonus { get; set; }
        public List<string> Proficiency { get; set; }
        public CharacterStats Stats { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }

        //public Background Background { get; set; }
        //public CharacterClass Class { get; set; }
        public List<Trait> Features { get; set; }
        public List<Item> Equipment { get; set; }

        public void LevelUp()
        {
            // Logic for leveling up the character
            Level++;
            ProficiencyBonus++; // Example: Proficiency bonus increases at certain levels
                                // Add more logic as needed
        }
    }
}