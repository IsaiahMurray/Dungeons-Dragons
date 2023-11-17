using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Character;
using ClassLibrary1.Character.Lineage.CommonRace;
using static DnDGame.UI.CreationMethods;

namespace DnDGame.UI
{
    public class ProgramUI
    {
        public void Run()
        {
            RunCreation();
        }
        private void RunCreation()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Select an option number:\n" +
                    "1. Create new character\n" +
                    "2. Exit");
                string userInput = Console.ReadLine();
                userInput = userInput.Replace(" ", "");
                switch (userInput)
                {
                    case "1":
                        CharacterCreation();
                        break;
                    case "2":
                        continueToRun = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public void CharacterCreation()
        {
            CreationMethods creationMethods = new CreationMethods();
            Character character = new Character();
            character.Race = new HumanRace();
            bool creationComplete = false;

            while (!creationComplete)
            {
                Console.Clear();
            Console.WriteLine(new DwarfRace().Name + " Da name");
                Console.WriteLine("Here is your current character: \n" +
                    $"Name: {character.Name}\n" +
                    $"Level: {character.Level}\n" +
                    $"Race: {creationMethods.GetRaceName(character.Race)}\n" +
                    $"Subrace: {character.Subrace}\n" +
                    $"Alignment: {character.Alignment}\n"
                    );
                Console.WriteLine("Select a number cooresponding with one of the options:\n" +
                    "1 - Name \n" +
                    "2 - Level\n" +
                    "3 - Race \n" +
                    "4 - Moral Alignment");
                string userInput1 = Console.ReadLine();

                switch (userInput1)
                {
                    case "1":
                        character.Name = creationMethods.AssignName();
                        break;

                    case "2":
                        character.Level = creationMethods.GetNumberInput("Enter a number between 1 and 20: ", 1, 20);
                        break;

                    case "3":
                        string prompt = "Enter a number for a race: \n" +
                            "1 - Dragonborn \n" +
                            "2 - Dwarf \n" +
                            "3 - Elf \n" +
                            "4 - Half Elf \n" +
                            "5 - Halfling \n" +
                            "6 - Half Orc \n" +
                            "7 - Human \n" +
                            "8 - Tiefling \n";
                        int input = creationMethods.GetNumberInput(prompt, 1, 8);
                        Race cRace;
                        cRace = creationMethods.AssignRace(input);
                        character.Race = cRace;
                        Console.ReadLine();
                        break;

                    default: break;
                }
            }
        }
    }
}
