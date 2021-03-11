using battleship.enums;

namespace battleship.gameElements
{
    public class Playground
    {

        public Field[,] Board { get; set; }
        
        public Players Player { get; set; }

        public Playground(int boardSize, Players player)
        {
            Board = new Field[boardSize, boardSize];
            this.Player = player;
        }
        
        
    
    }
}