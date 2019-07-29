using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    //What does a ship do, has different sizes, takes damage, gets destroyed
    class Ship
    {
        //TODO create more ship, make this one a Parent Class
        //Carrier size 5
        //Battleship size 4
        //Cruiser size 3
        //Submarine size 3
        //Destroyer size 2
        public MapLocation _location1 { get; private set; }
        public MapLocation _location2 { get; private set; }
        
        private int _locationOneHealth = 1;
        private int _locationTwoHealth = 1;

        //Sets the ship location on map
        public Ship(MapLocation location1, MapLocation location2)
        {
            _location1 = location1;
            _location2 = location2;
        }

        public bool ShipDestroyed()
        {
            return _locationOneHealth <= 0 && _locationTwoHealth <= 0;
        }

        public void ShipHit(int factor, MapLocation location)
        {
            if (location == _location1)
            {
                _locationOneHealth -= factor;
                Console.WriteLine("  Shot Hit!");
            }
            else if (location == _location2)
            {
                _locationTwoHealth -= factor;
                Console.WriteLine("  Shot Hit!");
            }
            else
            {
                Console.WriteLine("  Shot missed");
            }
        }
    }
}
