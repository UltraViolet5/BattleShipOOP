using System.Runtime.Intrinsics.X86;

namespace battleship.gameElements
{
    public struct Coordinates
    {
        public int x;
        public int y;

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}