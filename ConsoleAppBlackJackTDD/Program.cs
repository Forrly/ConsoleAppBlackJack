using System;

namespace ConsoleAppBlackJackTDD
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# BlackJack");
            Game game = new Game();
            game.Play();
        }
    }
}
