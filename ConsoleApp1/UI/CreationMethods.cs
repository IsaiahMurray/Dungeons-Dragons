using ClassLibrary1.Character;
using ClassLibrary1.Character.Lineage.CommonRace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDGame.UI
{
    public class CreationMethods
    {
        public string AssignName()
        {
            Console.WriteLine("Enter a name: ");
            string cName = Console.ReadLine();
            return cName;
        }
        public int GetNumberInput(string promptMessage, int minValue, int maxValue)
        {
            int userInput = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write(promptMessage);
                string input = Console.ReadLine();

                if (int.TryParse(input, out userInput))
                {
                    if (userInput >= minValue && userInput <= maxValue)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter a number between {minValue} and {maxValue}.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            return userInput;
        }
        public Race AssignRace(int input)
        {
            Race race = new HumanRace();
            switch (input)
            {
                case 1:
                    DragonbornRace dragonborn = new DragonbornRace();
                    race = dragonborn;
                    break;
                case 2:
                    DwarfRace dwarf = new DwarfRace();
                    race = dwarf;
                    break;
                case 3:
                    ElfRace elf = new ElfRace();
                    race = elf;
                    break;
                case 4:
                    HalfElfRace halfElf = new HalfElfRace();
                    race = halfElf;
                    break;
                case 5:
                    HalflingRace halfling = new HalflingRace();
                    race = halfling;
                    break;
                case 6:
                    HalfOrcRace halfOrc = new HalfOrcRace();
                    race = halfOrc;
                    break;
                case 7:
                    HumanRace human = new HumanRace();
                    race = human;
                    break;
                case 8:
                    TieflingRace tiefling = new TieflingRace();
                    race = tiefling;
                    break;
            }
            return race;
        }
    }
}
