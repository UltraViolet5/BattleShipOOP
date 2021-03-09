using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    public class Board
        {
        public int[,] ocean;
        
        public Board(int size)
            {
                ocean = new int[size, size];
            }
        }
}
