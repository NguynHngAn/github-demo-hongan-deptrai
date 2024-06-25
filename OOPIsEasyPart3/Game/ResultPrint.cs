

namespace OOPIsEasyPart3.Game
{
    public static class ResultPrint
    {
        public static void Print(GameResult gameResult)
        {
            var message = gameResult == GameResult.Victory
                ? "You win"
                : "You loss";
            Console.WriteLine(message);
        }
    }
}
