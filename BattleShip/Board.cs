using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    class Board
    {
        public readonly int Width;
        public readonly int Height;

        public Board(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnBoard(Point point)
        {
            return point.X >= 0 && point.X < Width &&
                   point.Y >= 0 && point.Y < Height;
        }
    }
}
