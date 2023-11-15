using ClassLibrary1.Character.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.Character.Lineage.CommonRace
{
    public class DwarfRace : Race
    {
        public DwarfRace(){}
        public DwarfRace(List<Trait> traits)
        {
            Name = "Dwarf";
            Description = "Kingdoms rich in ancient grandeur, halls carved into the roots of mountains, the echoing of picks and hammers in deep mines and blazing forges, a commitment to clan and tradition, and a burning hatred of goblins and orcs – these common threads unite all dwarves.";
            Traits = traits;
        }
        public string Name { get; }
        public string Description { get; }
        public List<Trait> Traits { get; set; }
    }
    public class HillDwarf : DwarfRace
    {
        public string Name { get; }
        public string Description { get; }
        public List<Trait> Traits { get; set; }
    }
    public class MountainDwarf : DwarfRace 
    {
        public string Name { get; }
        public string Description { get; }
        public List<Trait> Traits { get; set; }
    }

    public class DwarfTraits
    {
        private class ASIncrease : Trait
        {
            public ASIncrease()
            {
                TraitType = TypeOfTrait.RacialFeat;
                Name = "Ability Score Increase";
                Description = "Your Constitution score increases by 2.";
            }
        }

        private class Age : Trait
        {
            public Age()
            {
                TraitType = TypeOfTrait.RacialFeat;
                Name = "Age";
                Description = "Dwarves mature at the same rate as humans, but they're considered young until they reach the age of 50. On average, they live about 350 years.";
            }
        }

        private class Alignment : Trait
        {
            public Alignment()
            {
                TraitType = TypeOfTrait.RacialFeat;
                Name = "Alignment";
                Description = "Most dwarves are lawful, believing firmly in the benefits of a well-ordered society. They tend toward good as well, with a strong sense of fair play and a belief that everyone deserves to share in the benefits of a just order.";
            }
        }

        private class Size : Trait
        {
            public Size()
            {
                TraitType = TypeOfTrait.RacialFeat;
                Name = "Size";
                Description = "Dwarves stand between 4 and 5 feet tall and average about 150 pounds. Your size is Medium.";
            }
        }

        private class Speed : Trait
        {
            public Speed()
            {
                TraitType = TypeOfTrait.RacialFeat;
                Name = "Speed";
                Description = "Dwarves stand between 4 and 5 feet tall and average about 150 pounds. Your size is Medium.";
            }
        }

        private class Darkvision : Trait
        {
            public Darkvision()
            {
                TraitType = TypeOfTrait.RacialFeat;
                Name = "Darkvision";
                Description = "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray.";
            }
        }

        private class DwarvenResilience : Trait
        {
            public DwarvenResilience()
            {
                TraitType = TypeOfTrait.RacialFeat;
                Name = "Dwarven Resilience";
                Description = "You have advantage on saving throws against poison, and you have resistance against poison damage.";
            }
        }

        private class DwarvenCombatTraining : Trait
        {
            public DwarvenCombatTraining()
            {
                TraitType = TypeOfTrait.RacialFeat;
                Name = "Dwarven Combat Training";
                Description = "You have proficiency with the battleaxe, handaxe, light hammer, and warhammer.";
            }
        }

        private class ToolProficiency : Trait
        {
            public ToolProficiency()
            {
                TraitType = TypeOfTrait.RacialFeat;
                Name = "Tool Proficiency";
                Description = "You gain proficiency with the artisan's tools of your choice: smith's tools, brewer's supplies, or mason's tools.";
                //Add to proficiency
            }

        }

        private class Stonecunning : Trait
        {
            public Stonecunning()
            {
                TraitType = TypeOfTrait.RacialFeat;
                Name = "Stonecunning";
                Description = "Whenever you make an Intelligence (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus.";
            }
        }

        private class Languages : Trait
        {
            public Languages()
            {
                TraitType = TypeOfTrait.RacialFeat;
                Name = "Languages";
                Description = "You can speak, read, and write Common and Dwarvish. Dwarvish is full of hard consonants and guttural sounds, and those characteristics spill over into whatever other language a dwarf might speak.";
            }
        }

        public void ApplyEffects(Character character)
        {
            character.Stats.Constitution += 2;
            character.Speed += 25;
            character.Proficiency.Add("Battleaxe");
            character.Proficiency.Add("Handaxe");
            character.Proficiency.Add("Light hammer");
            character.Proficiency.Add("War hammer");
            character.Languages.Add("Common");
            character.Languages.Add("Dwarvish");

        }
    }
}
