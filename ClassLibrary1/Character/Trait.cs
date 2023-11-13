using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Character;

namespace ClassLibrary1.Character
{
    public abstract class Trait : ITrait
    {
        public TypeOfTrait TraitType { get; set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
    }

    /*public class SpeedTrait : Trait
    {
        public SpeedTrait()
        {
            Name = "Increased Speed";
            Description = "This race has increased movement speed.";
        }
    } */
}
