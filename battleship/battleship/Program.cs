using System;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display();
            
            Console.WriteLine("Podaj szerokość planszy : ");
            int row = Convert.ToInt32(Console.ReadLine());
            
            Board boardPlayerA = new Board(row);
            Board boardPlayerB = new Board(row);


            display.Ocean(boardPlayerA, boardPlayerB);

            boardPlayerA.ocean[0][0].ContainShip = true;
            display.Board(boardPlayerA);



        }
    }
}