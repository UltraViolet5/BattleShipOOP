using System;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Display display = new Display();
            display.Menu(0); // welcome text

            display.Menu(1); // welcome menu

            // display.Menu(2);// info about game

            //powiedzmy że chcemy planszę o wymiarach 5*5
            Board board_player_A = new Board(5);
            Board board_player_B = new Board(5);

            display.Ocean(board_player_A, board_player_B);



        }
    }
}