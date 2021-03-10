using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    public class Board
        {
        public int[,] ocean; // to powinna być dwu wymiarowa tablica obiektów typu field
        
        public Board(int size)
            {
                ocean = new int[size, size];
            }
        }
}
