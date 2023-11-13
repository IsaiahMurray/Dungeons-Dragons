using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Gameplay
{
    public enum DiceType { d4, d6, d8, d10, d12, d20 }

    public static class DiceRoller
    {
        private static readonly Random Random = new Random();

        // Roll a specified number of dice with a specific number of sides
        public static int Roll(int numberOfDice, DiceType die, int modifier = 0)
        {
            if (numberOfDice <= 0 || modifier < 0)
            {
                throw new ArgumentException("Number of dice must be greater than 0, and modifier must not be negative");
            }

            int result = 0;

            // Roll each die and accumulate the total
            for (int i = 0; i < numberOfDice; i++)
            {
                result += Random.Next(1, GetNumberOfSides(die) + 1);
            }

            return result + modifier;
        }

        private static int GetNumberOfSides(DiceType diceType)
        {
            // You can directly use the enum values without assigning integer values
            switch (diceType)
            {
                case DiceType.d4:
                    return 4;
                case DiceType.d6:
                    return 6;
                case DiceType.d8:
                    return 8;
                case DiceType.d10:
                    return 10;
                case DiceType.d12:
                    return 12;
                case DiceType.d20:
                    return 20;
                default:
                    throw new ArgumentException("Invalid dice type");
            }
        }
    }


}
