using battleship.enums;
using battleship.gameElements;

namespace battleship
{
    public class Game
    {
        
        
        public int BoardSize { get; set; }
        
        public Playground PlaygroundFirstPlayer { get; set; }
        public Playground PlaygroundSecondPlayer { get; set; }
        
        
        public Game(int boardSize)
        {
            this.BoardSize = boardSize;
            CreatePlaygrounds();
        }

        public void CreatePlaygrounds()
        {
            this.PlaygroundFirstPlayer = new Playground(this.BoardSize, Players.FirstPlayer);
            this.PlaygroundSecondPlayer = new Playground(this.BoardSize, Players.SecondPlayer);
            PlaygroundFirstPlayer.CreateBoard();
            PlaygroundSecondPlayer.CreateBoard();

        }
            
    }
}