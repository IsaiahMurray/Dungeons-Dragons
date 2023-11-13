using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Character.Traits
{
    public abstract class Trait : ITrait
    {
        public TypeOfTrait TraitType { get; set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
    }

}
