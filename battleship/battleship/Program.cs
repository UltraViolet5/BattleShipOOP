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
            int row = 5;//Convert.ToInt32(Console.ReadLine());
            //powiedzmy że chcemy planszę o wymiarach 5*5
            Board boardPlayerA = new Board(row);
            

            Console.WriteLine(boardPlayerA.ocean[0][0].ContainShip);
            // Poniższa linia zmienia zawartość statku o współrzędnych y = 0 i x = 1
            boardPlayerA.ocean[0][1].ContainShip = true;

            Console.WriteLine(boardPlayerA.ocean[0][1].ContainShip);


            /*
            if (boardPlayerA.ocean[0][0].ContainShip == false)
            {
                Console.WriteLine("NO SHIP");

            }
            else
            {
                Console.WriteLine("IS SHIP");

            }

            */

            //Console.WriteLine(Convert.ToString( boardPlayerA.ocean[0][0].State));

            Board boardPlayerB = new Board(row);

            display.Ocean(boardPlayerA, boardPlayerB);



        }
    }
}