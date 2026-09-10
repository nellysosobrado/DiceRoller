namespace DiceRoller.Models
{
    public class DiceResult
    {
        public List<int> Rolls { get; set; } = new List<int>();

        public int Total { get; set; }
        public double Average { get; set; }
        public int Highest { get; set; }
        public int Lowest { get; set; }
    }
}
