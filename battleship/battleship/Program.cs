using System;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display();
 
            int row;
            Console.WriteLine("Podaj szerokość planszy : ");
            row = Convert.ToInt32(Console.ReadLine());
            Board boardPlayerA = new Board(row);
            Board boardPlayerB = new Board(row);

            display.Ocean(boardPlayerA, boardPlayerB, row);



        }
    }
}