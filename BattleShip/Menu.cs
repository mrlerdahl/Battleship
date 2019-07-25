using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    class Menu
    {
        private string _userInput;
        private bool loopValue = true;
        public void StartMenu()
        {
            Console.WriteLine("  Would you like to start a game of battleship?");
            do
            {
                Console.Write("  Type Yes/No: ");
                _userInput = Console.ReadLine();

                //Use a swith statement?
                if (_userInput.ToLower() == "yes")
                {
                    loopValue = false;
                }
                else if (_userInput.ToLower() == "no")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\n\t**Invalide input**\n");
                }
            } while (loopValue);
        }
    }
}
