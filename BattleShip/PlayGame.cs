using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    class PlayGame
    {

        Board board = new Board(6, 6);
        Player playerOne = new Player("Player1");
        Player playerTwo = new Player("Player2");

        static void PlayerSetShip(Player player, Board board)
        {
            Console.WriteLine("  " + player.playerName);
            Console.WriteLine("  Set location of your ship:");
            Console.Write("  Set x1 coordinate: ");
            player.x1 = Player.userValidation(int.Parse(Console.ReadLine()));
            Console.Write("  Set y1 coordinate: ");
            player.y1 = Player.userValidation(int.Parse(Console.ReadLine()));
            Console.Write("  Set x2 coordinate: ");
            player.x2 = Player.userValidation(int.Parse(Console.ReadLine()));
            Console.Write("  Set y2 coordinate: ");
            player.y2 = Player.userValidation(int.Parse(Console.ReadLine()));
        }

        public PlayGame()
        {

            int playerTurn = 0;
            int shotLocationOne;
            int shotLocationTwo;
            MapLocation mapShotLocation;

            try
            {

                Menu menu = new Menu();
                menu.StartMenu();

                PlayerSetShip(playerOne, board);
                
                for (int i = 0; i < 30; i++)
                {
                    if(i == 15)
                    {
                        Console.WriteLine("\tDon't scroll up cheater!");
                    }
                    Console.WriteLine(" ");
                }

                PlayerSetShip(playerTwo, board);

                playerOne.SetShip(new MapLocation(playerOne.x1, playerOne.y1, board), new MapLocation(playerOne.x2, playerOne.y2, board));
                playerTwo.SetShip(new MapLocation(playerTwo.x1, playerTwo.y1, board), new MapLocation(playerTwo.x2, playerTwo.y2, board));

                Console.WriteLine("\n\tGame will now start!\n");
                while (!playerOne.ship.ShipDestroyed() && !playerTwo.ship.ShipDestroyed())
                {
                    if (playerTurn == 0)
                    {
                        Console.WriteLine("  " + playerOne.playerName + "'s turn");
                        Console.Write("  Enter X coordiante: ");
                        shotLocationOne = Player.userValidation(int.Parse(Console.ReadLine()));
                        Console.Write("  Enter Y coordiante: ");
                        shotLocationTwo = Player.userValidation(int.Parse(Console.ReadLine()));
                        mapShotLocation = new MapLocation(shotLocationOne, shotLocationTwo, board);
                        playerTwo.FireOnShip(mapShotLocation);
                        playerTurn++;
                    }
                    else
                    {
                        Console.WriteLine("  " + playerTwo.playerName + "'s turn");
                        Console.Write("  Enter X coordiante: ");
                        shotLocationOne = int.Parse(Console.ReadLine());
                        Console.Write("  Enter Y coordiante: ");
                        shotLocationTwo = int.Parse(Console.ReadLine());
                        mapShotLocation = new MapLocation(shotLocationOne, shotLocationTwo, board);
                        playerOne.FireOnShip(mapShotLocation);
                        playerTurn--;
                    }
                }

                if (playerOne.ship.ShipDestroyed())
                {
                    Console.WriteLine("\n\tPlayer Two wins!!\n");
                }
                if (playerTwo.ship.ShipDestroyed())
                {
                    Console.WriteLine("\n\tPlayer One wins!!\n");
                }
                //Add a ship count to determin who wins. So ships will have health
                //but determining who wins is when all ships are destroyed

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
