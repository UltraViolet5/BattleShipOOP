using battleship.enums;
using battleship.gameElements;
using System.Collections.Generic;
using battleship.enums;

namespace battleship
{
    public class Game
    {
        
        
        public int BoardSize { get; set; }
        /*
        public Playground PlaygroundFirstPlayer { get; set; }
        public Playground PlaygroundSecondPlayer { get; set; }
        */

        public Board boardPlayerA ;
        public Board boardPlayerB ;

        public List<Ship> shipPlayerA;
        public List<Ship> shipPlayerB;


        public Game()
        {
            /*
            this.BoardSize = boardSize;
            CreatePlaygrounds();
            */
            Input input = new Input();

            BoardSize = input.GetBoardSize();

            this.boardPlayerA  = new Board(BoardSize);
            this.boardPlayerB = new Board(BoardSize);

            shipPlayerA = ShipPlacement(this.boardPlayerA, enums.Players.FirstPlayer); // pierwszym graczem jest gracz A
            shipPlayerB = ShipPlacement(this.boardPlayerB, enums.Players.SecondPlayer); // drugim graczem jest gracz B

            Display display = new Display();
            display.Ocean(this.boardPlayerA, this.boardPlayerB); // trzeba przerobić funkcję display ocean żeby za każdym razem się statki na nowo
            // do niej przypisywały i dopiero wtedy się wyświetlały

            //Board boardPlayerA





        }
        /*
        public void CreatePlaygrounds()
        {
            this.PlaygroundFirstPlayer = new Playground(this.BoardSize, Players.FirstPlayer);
            this.PlaygroundSecondPlayer = new Playground(this.BoardSize, Players.SecondPlayer);
            PlaygroundFirstPlayer.CreateBoard();
            PlaygroundSecondPlayer.CreateBoard();

        }
        */

        public List<Ship> ShipPlacement(Board boardPlayer, battleship.enums.Players player  )
        {
            Display display = new Display();
            
            switch (player)
            {
                case Players.FirstPlayer:
                    display.Write("Seting ship of player A");
                    break;
                case Players.SecondPlayer:
                    display.Write("Seting ship of player B");
                    break;
            }

            Board board = new Board(this.BoardSize);
            List<Ship> PlayerShips = new List<Ship> { };
            
            board.PlaceShip(PlayerShips);

            Input input = new Input();

            Coordinates cordinates_ship1 = input.GetCoordinates();

            enums.Position position_ship1 = input.GetPosition();

            Ship ship1 = new Ship(1, enums.Players.FirstPlayer, cordinates_ship1, position_ship1);

            

            PlayerShips.Add(ship1);

            //display.Board()  tutaj ma się wyświetlać plansza z pierwszym statkiem trzeba metodę display board przerobić


            board.PlaceShip(PlayerShips);



            Coordinates cordinates_ship2 = input.GetCoordinates();

            enums.Position position_ship2 = input.GetPosition();

            Ship ship2 = new Ship(1, enums.Players.FirstPlayer, cordinates_ship2, position_ship2);

            PlayerShips.Add(ship2);
            board.PlaceShip(PlayerShips);


            Coordinates cordinates_ship3 = input.GetCoordinates();

            enums.Position position_ship3 = input.GetPosition();

            Ship ship3 = new Ship(1, enums.Players.FirstPlayer, cordinates_ship1, position_ship3);

            PlayerShips.Add(ship3);

            board.PlaceShip(PlayerShips);


            return PlayerShips;

        }

        public void Battleship()
        {

        }


            
    }
}