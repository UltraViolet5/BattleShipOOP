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

        public Coordinates[] PlaceShip(Position position, Coordinates place, int quantityOfMast)
        {
            Coordinates[] coordinates = new []{place};
            
            switch (position)
            {
                case Position.Horizontal :
                    
                    for (int i = 0; i < quantityOfMast; i++)
                    {
                        place.x += 1;
                        coordinates.Append(place);
                    }

                    return coordinates;
                
                case Position.Vertical:
                    for (int i = 0; i < quantityOfMast; i++)
                    {
                        place.y += 1;
                        coordinates.Append(place);
                    }
                    return coordinates;
                    
                   
                
            }
            
            
        }
        
        
        
    }
}