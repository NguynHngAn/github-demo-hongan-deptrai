using OOPIsEasyPart3.Game;
using System.Net.Http.Headers;

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GameProgress(dice);
var gameResult = guessingGame.Play();
ResultPrint.Print(gameResult);



Console.ReadKey();
