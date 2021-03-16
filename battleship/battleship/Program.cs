using System;
using battleship.gameElements;
using System.Collections.Generic;


namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new Game();
            
            
            
            /*
            Display display = new Display();
            
            Console.WriteLine("Podaj szerokość planszy : ");
            int row = Convert.ToInt32(Console.ReadLine());
            
            Board boardPlayerA = new Board(row);
            Board boardPlayerB = new Board(row);
            
            Coordinates cordinates_ship1 = new Coordinates();
            cordinates_ship1.x = 0;
            cordinates_ship1.y = 0;

            Ship ship1 = new Ship(1, enums.Players.FirstPlayer, cordinates_ship1, enums.Position.Vertical);

            Coordinates cordinates_ship2 = new Coordinates();
            cordinates_ship2.x = 3;
            cordinates_ship2.y = 3;


            Ship ship2 = new Ship(2, enums.Players.FirstPlayer, cordinates_ship2, enums.Position.Vertical);

            Coordinates cordinates_ship3 = new Coordinates();
            cordinates_ship3.x = 5;
            cordinates_ship3.y = 5;

            Ship ship3 = new Ship(3, enums.Players.FirstPlayer, cordinates_ship3, enums.Position.Vertical);



            List<Ship> ShipsPlayerA = new List<Ship> { };

            ShipsPlayerA.Add(ship1);
            ShipsPlayerA.Add(ship2);
            ShipsPlayerA.Add(ship3);



            boardPlayerA.PlaceShip(ShipsPlayerA);


            display.Ocean(boardPlayerA, boardPlayerB);

            //boardPlayerA.ocean[0][0].ContainShip = true;
            display.Board(boardPlayerA);
            */
            

        }
    }
}