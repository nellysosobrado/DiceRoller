using DiceRoller.Models;

namespace DiceRoller.Services
{
    public class DiceService
    {
        public DiceResult Roll(int numberOfRolls)
        {
            List<int> rolls = new List<int>();

            for(int i = 0; i< numberOfRolls;i++)
            {
                int diceRoll = Random.Shared.Next(1, 7);

                rolls.Add(diceRoll);

            }
            DiceResult result = new DiceResult();

            result.Rolls = rolls;
            result.Total = rolls.Sum();
            result.Average = rolls.Average();
            result.Highest = rolls.Max();
            result.Lowest = rolls.Min();

            return result;
        }
        //public int Roll()
        //{
        //    return Random.Shared.Next(1, 7);
        //}
    }
}
