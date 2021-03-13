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
            //display.Menu(enums.DisplayText.BoardSizeInput);
            int row = 5;//Convert.ToInt32(Console.ReadLine());
            //powiedzmy że chcemy planszę o wymiarach 5*5
            Board boardPlayerA = new Board(row);
            Board boardPlayerB = new Board(row);


            boardPlayerA.ocean[0][0].State = enums.SateOfField.Hit;
            Console.WriteLine(boardPlayerA.ocean[0][0].Symbol);




            display.Ocean(boardPlayerA, boardPlayerB, row);



        }
    }
}