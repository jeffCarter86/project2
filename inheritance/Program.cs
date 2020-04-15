using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GameStart();
            game.GameLoop();
            game.EndGame();
        }
    }
}
