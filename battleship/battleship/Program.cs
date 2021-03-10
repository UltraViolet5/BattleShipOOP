using System;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Display display = new Display();
            display.Menu(enums.DisplayText.WelcomeGraphic); // welcome text

            display.Menu(enums.DisplayText.WelcomeMenu ); // welcome menu

            //display.Menu(enums.DisplayText.InfoAboutGame);// info about game
            display.Menu(enums.DisplayText.BoardSizeInput);
            int row = Convert.ToInt32(Console.ReadLine());
            //powiedzmy że chcemy planszę o wymiarach 5*5
            Board boardPlayerA = new Board(row);
            Board boardPlayerB = new Board(row);

            display.Ocean(boardPlayerA, boardPlayerB);



        }
    }
}