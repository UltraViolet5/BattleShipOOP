using battleship.enums;
using battleship.gameElements;

namespace battleship
{
    public class Game
    {
        
        
        public int BoardSize { get; set; }
        
        public Playground playgroundFirstPlayer { get; set; }
        public Playground playgroundSecondPlayer { get; set; }
        
        
        public Game(int boardSize)
        {
            this.BoardSize = boardSize;
        }

        public void Playgrounds()
        {
            this.playgroundFirstPlayer = new Playground(this.BoardSize, Players.FirstPlayer);
            this.playgroundSecondPlayer = new Playground(this.BoardSize, Players.SecondPlayer);
            
        }
            
    }
}