using ClassLibrary1.Character.Lineage.CommonRace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1.Character.Lineage
{

    //Create lineage type that implements the ILineage interface with it's properties 
    public class CommonLineage : ILineage
    {
        //Define the required properties from the interface
        public required TypeOfLineage LineageType { get; set; }
        public required List<Race> Races { get; set; }

        //Build a constructor that defines the set properties
        public CommonLineage()
        {
            LineageType = TypeOfLineage.Common;

            //Make a list that holds the races that fall under the "Common" lineage
            List<IRace> commonRaces = new()
            {
                new DragonbornRace(),
                new DwarfRace(),
                new ElfRace(),
                new GnomeRace(),
                new HalfElfRace(),
                new HalflingRace(),
                new HalfOrcRace(),
                new HumanRace(),
                new TieflingRace()
            };

            //Add the list to the list of Races property
            Races.AddRange((IEnumerable<Race>)commonRaces);
        }        
    }
}
