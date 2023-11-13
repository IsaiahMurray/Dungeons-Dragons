using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Gameplay
{
    public static class DiceRoller
    {
        private static readonly Random Random = new Random();

        // Roll a specified number of dice with a specific number of sides
        public static int Roll(int numberOfDice, int numberOfSides, int modifier = 0)
        {
            if (numberOfDice <= 0 || numberOfSides <= 0)
            {
                throw new ArgumentException("Number of dice and number of sides must be greater than 0");
            }

            int result = 0;

            // Roll each die and accumulate the total
            for (int i = 0; i < numberOfDice; i++)
            {
                result += Random.Next(1, numberOfSides + 1);
            }

            return result + modifier;
        }
    }
}
