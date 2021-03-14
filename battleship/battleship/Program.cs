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


            display.Ocean(boardPlayerA, boardPlayerB);// wyświetla ocean czyli dwie plansze graczy

            boardPlayerA.ocean[0][0].ContainShip = true; // w pozycji [y][x] => [0][0] stawiany jest statek więc na pojedyńczej
                                                         //planszy się wyświetli #
            
            display.Board(boardPlayerA);// wyświetla planszę jednego gracza i pokazuje gdzie są statki



        }
    }
}