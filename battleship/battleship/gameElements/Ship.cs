using System.Collections.Generic;
using System.Linq;
using battleship.enums;


namespace battleship.gameElements
{
    public class Ship
    {
        private int QuantityOfMast { get; set; }

        public Players Player { get; set; }

        public Coordinates Place { get; set; }
        
        public Position Position { get; set; }


        public Ship(int quantityOfMast, Players player, Coordinates place, Position position)
        {
            this.QuantityOfMast = quantityOfMast;
            this.Player = player;
            this.Place = place;
            this.Position = position;
        }

        public List<Coordinates> PlaceShip()
        {
            List<Coordinates> coordinates = new List<Coordinates>();
            coordinates.Add(this.Place);
            
            switch (Position)
            {
                case Position.Horizontal :
                    
                    for (int i = 0; i < this.QuantityOfMast; i++)
                    {
                        Coordinates newCoordinates = Place;
                        newCoordinates.x += 1;
                        coordinates.Add(newCoordinates);
                    }

                    return coordinates;
                
                case Position.Vertical:
                    for (int i = 0; i < this.QuantityOfMast; i++)
                    {
                        Coordinates newCoordinates = Place;
                        newCoordinates.y += 1;
                        coordinates.Add(newCoordinates);
                    }
                    return coordinates;
                default:
                    return coordinates;
            }
            
            
        }
        
        
        
    }
}