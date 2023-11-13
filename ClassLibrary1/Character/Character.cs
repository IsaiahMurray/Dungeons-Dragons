using ClassLibrary1.Character.CharacterClass;
using ClassLibrary1.Character.Spells;
using static ClassLibrary1.Character.Skills.SkillList;

namespace ClassLibrary1.Character
{
    public enum Size { Tiny, Small, Medium, Large, Huge, Gargantuan }
    public enum ArmorClass { Light, Medium, Heavy }
    public enum Alignment { Lawful_Good, Lawful_Neutral, Lawful_Evil, Chaotic_Good, Chaotic_Neutral, Chaotic_Evil, Neutral_Good, True_Neutral, Neutral_Evil }
    public class Character
    {
        public Character() { }
        public Character(string name, int level)
        {
            Name = name;
            Level = level;  
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
        public CharacterStats Stats { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
    }
}