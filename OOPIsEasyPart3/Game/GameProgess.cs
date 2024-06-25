

using OOPIsEasyPart3.UserCommunication;

namespace OOPIsEasyPart3.Game
{
    public class GameProgress
    {
        private readonly Dice _dice;
        private const int InitialTries = 3;

        public GameProgress(Dice dice)
        {
            _dice = dice;
        }
        public GameResult Play()
        {
            Console.WriteLine(
                "Dice rolled. Enter you guessing number in 3 tries.");
            var triesLeft = InitialTries;
            var rollResult = _dice.Roll();
            while (triesLeft > 0)
            {
                if (rollResult == ConsoleReader.ReadInteger("Enter you number: "))
                {
                    return GameResult.Victory;
                }
                --triesLeft;
                Console.WriteLine("Wrong number.");
            }
            return GameResult.Loss;
        }
    }
}
