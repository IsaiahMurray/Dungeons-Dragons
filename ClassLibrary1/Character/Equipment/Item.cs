using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Character.Equipment
{
    public enum TypeOfItem { Weapon, Armor, Shield, Trinket, Adventuring_Gear, Firearms, Explosives, Wondrous, Currency, Poison, Tools, Siege, Custom }
    public class Item
    {
        public TypeOfItem ItemType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // Add more properties as needed
    }
}
