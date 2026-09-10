namespace DiceRoller.Services
{
    public class DiceService
    {
        public int Roll()
        {
            return Random.Shared.Next(1, 7);
        }
    }
}
