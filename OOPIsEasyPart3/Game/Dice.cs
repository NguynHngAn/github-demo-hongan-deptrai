

namespace OOPIsEasyPart3.Game
{
    public class Dice
    {
        private readonly Random _dice;
        private const int SidesCount = 6;
        public Dice(Random dice)
        {
            _dice = dice;
        }

        public int Roll()
        {
            return _dice.Next(1, SidesCount + 1);
        }
    }
}
