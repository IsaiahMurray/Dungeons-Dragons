using ClassLibrary1.Character.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Character
{

    // Interface for character class
    public interface ICharacterClass
    {
        string ClassName { get; }
        string Description { get; }
        List<Trait> Traits { get; }
    }


    // Interface for traits
    public enum TypeOfTrait { ClassTrait, RacialFeat }
    public interface ITrait
    {
        public TypeOfTrait TraitType { get; set; }
        string Name { get; }


        //Effect property => function that alters something
    }

    // Interface for races
    public interface IRace
    {
        string Name { get; }
        public string Description { get; }

        List<Trait> Traits { get; }
    }
    public abstract class Race : IRace
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public List<Trait> Traits { get; protected set; }

        protected Race()
        {
            Traits = new List<Trait>();
        }
    }

    // Interface for lineages
    public enum TypeOfLineage { Common, Exotic, Monstrous, Setting_Specific, Unearthed_Arcana, Custom };
    public interface ILineage
    {
        TypeOfLineage LineageType { get; }
        List<Race> Races { get; }
    }
}
