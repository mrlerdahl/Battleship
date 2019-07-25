using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    class Player
    {
        public readonly string playerName;
        private const int power = 1;

        private int _x1;
        private int _x2;
        private int _y1;
        private int _y2;

        public int x1
        {   get
            {
                return _x1;
            }
            set
            {
                _x1 = userValidation(value);
            } 
        }
        public int x2
        {
            get
            {
                return _x2;
            }
            set
            {
                _x2 = userValidation(value);
            }
        }
        public int y1
        {
            get
            {
                return _y1;
            }
            set
            {
                _y1 = userValidation(value);
            }
        }
        public int y2
        {
            get
            {
                return _y2;
            }
            set
            {
                _y2 = userValidation(value);
            }
        }
      
        public Ship ship;

        public Player(string name) => playerName = name;

        //Need more set ships methods, expample SetShipOne, SetShipTwo etc..
        public void SetShip(MapLocation locationOne, MapLocation LocationTwo)
        {
            ship = new Ship(locationOne, LocationTwo);
        }

        public void FireOnShip(MapLocation location)
        {
            if(location == ship._location1)
            {
                ship.ShipHit(power, location);
            }
            else if(location == ship._location2)
            {
                ship.ShipHit(power, location);
            }
            else
            {
                ship.ShipHit(power, location);
            }
        }

        public static int userValidation(int coordinate)
        {
            if (coordinate < 0 || coordinate > 5)
            {
                while (coordinate < 0 || coordinate > 5)
                {
                    Console.WriteLine("\n\t**Please enter a number between 0 and 5.**\n");
                    Console.Write("  Enter coordinate: ");
                    coordinate = int.Parse(Console.ReadLine());   
                }
                return coordinate;
            }
            else
            {
                return coordinate;
            }
        }
    }
}
