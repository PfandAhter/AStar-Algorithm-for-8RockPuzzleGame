using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarAlgorithmFor8PuzzleGame
{
    public class Tile
    {
        public int Value { get; set; }

        public Tile (int value)
        {
            Value = value;
        }

        public bool IsEmpty()
        {
            return Value == 0;
        }

        public override string ToString()
        {
            return IsEmpty() ? " " : Value.ToString();
        }
    }
}
