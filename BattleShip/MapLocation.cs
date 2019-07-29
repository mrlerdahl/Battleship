using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    class MapLocation : Point
    {
        
        public MapLocation(int x, int y, Board board) : base(x, y)
        {
            if (!board.OnBoard(this))
            {
                throw new System.Exception(x + "," + y + " is outside the bounderies of the board");
            }
        }
        public static bool operator ==(MapLocation x, MapLocation y)
        {
            return x.Equals(y);
        }
        public static bool operator !=(MapLocation x, MapLocation y)
        {
            return !(x == y);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is MapLocation))
                return false;

            var other = obj as MapLocation;

            if (X != other.X || Y != other.Y)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() * 31 + Y.GetHashCode();
        }
    }
}
