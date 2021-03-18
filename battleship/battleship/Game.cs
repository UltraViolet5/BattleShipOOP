﻿using battleship.enums;
using battleship.gameElements;
using System.Collections.Generic;
using battleship.enums;
using System;

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
            Display display = new Display();
            display.Menu(DisplayText.BoardSizeInput); // 
            
            Input input = new Input();
            
            BoardSize = input.GetBoardSize();

            this.boardPlayerA  = new Board(BoardSize);
            this.boardPlayerB = new Board(BoardSize);

            shipPlayerA = ShipPlacement(this.boardPlayerA, enums.Players.FirstPlayer); // pierwszym graczem jest gracz A
            shipPlayerB = ShipPlacement(this.boardPlayerB, enums.Players.SecondPlayer); // drugim graczem jest gracz B

            // rozpoczynamy bitwę !
            this.Battleship();
            // trzeba dodać funkcję sprawdzającą czy statek jest zatopiony
            
            // bitwa ma się zakończyć wygraną jednego z graczy






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
                    display.Clear();
                    display.Write("Seting ship of player A");
                    break;
                case Players.SecondPlayer:
                    display.Clear();
                    display.Write("Seting ship of player B");
                    break;
            }

            Board board = new Board(this.BoardSize);
            List<Ship> PlayerShips = new List<Ship> { };
            
            board.PlaceShip(PlayerShips);

            Input input = new Input();
            // wyświetl pustą planszę bez statków
            display.Board(this.PutShipsOnBoard(boardPlayer, PlayerShips));// było boardPlayerA

            Coordinates cordinates_ship;
            enums.Position position_ship;
            Ship ship;

            
            for(int iterate = 1; iterate <= 3; iterate++)
            {
                //Poproś o koordynaty statku
                cordinates_ship = input.GetCoordinates();
                //Poproś o pozycję czy statek ma być pionowo czy poziomo
                position_ship = input.GetPosition();

                ship = new Ship(iterate, enums.Players.FirstPlayer, cordinates_ship, position_ship);

                PlayerShips.Add(ship);
                // wyczyść ekran
                display.Clear();

                // wyświetl planszę ze statkami
                display.Board(this.PutShipsOnBoard(boardPlayer, PlayerShips));

            }
            return PlayerShips;
        }

        //poniższa funkcja jest potrzebna do wyświetlania statków w metodzie display.board
        public Board PutShipsOnBoard(Board boardPlayer, List<Ship> shipList)
        {
            List<Coordinates> shipCoodrinatesList;
            foreach(Ship ship in shipList)
            {
                shipCoodrinatesList = ship.GetShipCoordinates();
                foreach(Coordinates coord in shipCoodrinatesList)
                {
                    boardPlayer.ocean[coord.y][coord.x].ContainShip = true;
                }
            }
            return boardPlayer;
        }


        public void Battleship()
        {
            Display display = new Display();

            // Wyświetl ekran rozpoczęcia bitwy 
            display.Menu(DisplayText.BattleshipBegin);
            
            
            // Wyświetl pole bitwy - ocean
            display.Ocean(this.boardPlayerA, this.boardPlayerB);

            bool is_running = true;
            while (is_running)
            {
                Round(Players.FirstPlayer);
                display.Clear();
                display.Ocean(boardPlayerA, boardPlayerB);
                // tutaj trzeba dodać kod sprawdzający czy któryś z graczy wygrał

                
                Round(Players.SecondPlayer);
                display.Clear();
                display.Ocean(boardPlayerA, boardPlayerB);
                // tutaj trzeba dodać kod sprawdzający czy któryś z graczy wygrał

            }





        }

        public void Round(enums.Players player)
        {
            Input input = new Input();
            Coordinates coord;
            Display display = new Display();
            
            if (player == Players.FirstPlayer)
            {
                display.Write("Player A is shooting");
            }
            else 
            {
                display.Write("Player B is shooting");
            }

            coord = input.GetCoordinates();
            
            if (player == Players.FirstPlayer)
            {
                Shot(coord, this.boardPlayerB, player);
            }
            else
            {
                Shot(coord, this.boardPlayerA, player);
            }


        }

        public void Shot(Coordinates coord, Board boardPlayer, enums.Players shooter)
        {
            Display display = new Display();
            // jak jest runda firstplayera to strzelamy do tarczy gracza b
            // jak jest runda secondplayera to strzelamy do tarczy gracza a
            
            switch (boardPlayer.ocean[coord.y][coord.x].State)
            {
                /*            
                Fired,// ostrzelane pole bez statku N
                Free,// wolne pole F
                Hit,// uderzony H
                HitSunk // trafiony zatopiony S
                    
                */

                // jeżeli wolne pole 
                case SateOfField.Free:
                    if (boardPlayer.ocean[coord.y][coord.x].ContainShip == true)
                    {
                        boardPlayer.ocean[coord.y][coord.x].State = SateOfField.Hit;
                        //poniżej powinna być funkcja sprawdzająca  czy wszystkie maszty są już zatopione
                        // i wtedy jak tak to powinna zamienić maszty na sunk

                        //tutaj powinna być funkcja sprawdzająca czy graczB już przegrał czy jescze nie

                    }
                    else
                    {
                        // jeżeli strzelamy a niema statku to oznaczamy pole jako ostrzelane
                        boardPlayer.ocean[coord.y][coord.x].State = SateOfField.Fired;
                    }

                    break;
                    // jeżeli ostrzelane pole bez statku
                    case SateOfField.Fired:
                    // jeżeli gracz strzelił w ostrzelane pole to:
                    display.Clear();
                    display.Write("This field was shoted before!");
                    break;
                    // jeżeli statek został ostrzelany
                    case SateOfField.Hit:
                    display.Clear();
                    display.Write("This field was shoted before!");

                    break;
                    // jeżeli statek został zatopiony
                    case SateOfField.HitSunk:
                    display.Clear();
                    display.Write("This field was shoted before!");

                    break;

            }

            if (shooter == Players.FirstPlayer)
            {
                this.boardPlayerB = boardPlayer;
            }
            else
            {
                this.boardPlayerA = boardPlayer;
            }

        }
    }
}