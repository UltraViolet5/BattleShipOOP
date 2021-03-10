using System;
using System.Dynamic;
using battleship.enums;

namespace battleship.gameElements
{
    public class Field
    {
        
        public SateOfField State { get; set; }
        
        public bool ContainShip { get; set; }

        public string Symbol
        {
            get
            {
                return this.State switch
                {
                    SateOfField.Free => "█",
                    SateOfField.Fired => "X",
                    SateOfField.Hit => "◙",
                    SateOfField.HitSunk => "☼",
                    _ => "█"
                };
            }
            private set{}
        }


    }
}