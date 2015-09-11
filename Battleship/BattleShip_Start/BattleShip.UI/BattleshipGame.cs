using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace BattleShip.UI
{

    public class BattleshipGame
    {
        // dat
        private PlayerDto _p1Dto;
        private PlayerDto _p2Dto;
        private bool _isVictory;
        private int _quit;
        // ctor
        public BattleshipGame()
        {
            _p1Dto = new PlayerDto();
            _p2Dto = new PlayerDto();
            _quit = 2;
        }
        // fn
        public void PlayGame()
        {
            do
            {
                SetUpBoards();

                while (!_isVictory)
                {
                    YourTurnMessageToPlayer(1);
                    ProcessTurn(_p2Dto);
                    if (_isVictory) break;
                    YourTurnMessageToPlayer(2);
                    ProcessTurn(_p1Dto);
                    if (_isVictory) break;
                }
                _quit = AskUser();
                Console.Clear();

            } while (_quit == 1);

        }
        // priv
        private int AskUser()
        {
            var choiceGetter = new ChoiceGetter();
            return choiceGetter.GetChoice("\n> Play another? - (Enter 1 to play again OR 2 to EXIT the game): ");
        }

        private void YourTurnMessageToPlayer(int v)
        {
            Console.WriteLine("\n Player{0}, it's your turn!", v);

            //Console.WriteLine("\n (Enter shot coordinate as follows: e.g. a1, b6, j10 etc.)");
        }

        private void ProcessTurn(PlayerDto inDto)
        {
            Shoot(inDto);
            Console.WriteLine("\n\n> Press enter to continue...\n");
            Console.ReadLine();
            Console.Clear();
        }

        private void Shoot(PlayerDto inDto)
        {
            bool isShotValid = false;

            while (!isShotValid)
            {
                var coordGetter = new CoordGetter();

                //Console.Clear();

                DisplayShotHistory(inDto);

                var coord = coordGetter.GetCoord("> Enter Shot Coord (Ex: a1, b6) :   ");

                var response = inDto.Board.FireShot(coord);

                Console.Clear();

                Console.WriteLine("\n Shot result: ");

                DisplayShotHistory(inDto);

                if (response.ShotStatus == ShotStatus.Duplicate || response.ShotStatus == ShotStatus.Invalid)
                {
                    Console.WriteLine("\nThat was not a valid shot, ({0}), Take another shot!", response.ShotStatus.ToString());

                    Console.WriteLine("\n Press Enter to re-take shot...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\n Shot result: ");

                    //mt
                    //Console.ReadLine();
                    //Console.Clear();

                }

                else if (response.ShotStatus == ShotStatus.Miss)
                {
                    Console.Write("\nSplash! - You MISSED...");
                    isShotValid = true;
                }

                else if (response.ShotStatus == ShotStatus.Hit)
                {
                    Console.Write("\nBOOM! *** You hit something!");
                    isShotValid = true;
                }

                else if (response.ShotStatus == ShotStatus.HitAndSunk)
                {
                    Console.Write("\nBAAM! *** You hit and SUNK a {0}", response.ShipImpacted.ToString());
                    isShotValid = true;
                }

                else
                {
                    Console.WriteLine("\nVICTORY! - you just WON!!!");
                    _isVictory = true;
                    break;
                }
            }
        }

        private void DisplayShotHistory(PlayerDto inDto)
        {
            var dto = inDto;

            Console.WriteLine();
            string header = " A  B  C  D  E  F  G  H  I  J".PadLeft(33, ' ');
            Console.WriteLine(header);
            Console.WriteLine("-----------------------------".PadLeft(33, ' '));

            for (int i = 1; i < 11; i++)
            {
                Console.Write("{0}| ", i.ToString().PadLeft(2, ' '));
                for (int j = 1; j < 11; j++)
                {
                    var myCoord = new Coordinate(j, i);

                    if (dto.Board.ShotHistory.ContainsKey(myCoord))
                    {
                        if (dto.Board.ShotHistory[myCoord] == ShotHistory.Hit)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" H ");
                            Console.ResetColor();
                        }

                        else if (dto.Board.ShotHistory[myCoord] == ShotHistory.Miss)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(" m ");
                            Console.ResetColor();
                        }
                    }

                    else
                    {
                        Console.Write(" * ");
                    }

                }
                Console.WriteLine();

                //Console.Write(" |{0}\n", i);
            }
        }

        private void SetUpBoards()
        {
            DisplayBattleship();
            Console.WriteLine("\n*** Players, it's time to set up your boards!\n");
            _p1Dto.Name = GetName(1);
            Console.WriteLine("\n*** Ship Placement Input \n\n   Coordinates: Enter Letters A - J Horizontally, Numbers 1 - 10 Vertically    ");
            PrintShipLenght();
            PlaceShips(_p1Dto);
            Console.WriteLine("\n> Player1 setup complete!, hit enter for Player2 set up...");
            Console.ReadLine();
            Console.Clear();
            _p2Dto.Name = GetName(2);
            Console.WriteLine("\n*** Ship Placement Input \n\n   Coordinates: Enter Letters A - J Horizontally, Numbers 1 - 10 Vertically    ");
            PrintShipLenght();
            PlaceShips(_p2Dto);
            Console.WriteLine("\n*** Set up is complete - time to start the game!");
            Console.WriteLine("\n> Press enter to continue...");
            //Console.ReadLine();
            Console.Clear();
        }

        private void PrintShipLenght()
        {
            Console.WriteLine();
            Console.WriteLine(@"   Ship Type (length): 
                       Destroyer(2), 
                       Cruiser(3),
                       Sub(3), 
                       Battleship(4),
                       Carrier(5).");
        }

        private void DisplayBattleship()
        {
            Console.WriteLine(




                @"                                






                                 BATTLESHIP



                         > Press Enter to Continue...");

            Console.ReadLine();
            Console.Clear();
        }

        private void PlaceShips(PlayerDto inDto)
        {
            int a = Enum.GetNames(typeof(ShipType)).Length;

            for (int i = 0; i < a; i++)
            {
                bool isPlacementOk = false;

                while (!isPlacementOk)
                {
                    string shipType = ((ShipType)i).ToString();
                    var coordGetter = new CoordGetter();
                    var shipPointer = new ShipPointer();

                    PlaceShipRequest request = new PlaceShipRequest()
                    {
                        Coordinate = coordGetter.GetCoord((i + 1).ToString() + ".  " + "Enter coordinate for your " + shipType.ToString() + ":  "),
                        Direction = shipPointer.PointShip("    Ship direction: (L-left, R-right, U-up, D-down): "),
                        ShipType = (ShipType)i
                    };

                    var responce = inDto.Board.PlaceShip(request);
                    string r = responce.ToString();

                    if (r == ShipPlacement.Ok.ToString())
                    {
                        isPlacementOk = true;
                        Console.WriteLine("    Ship placement status: {0}", r);
                    }

                    else Console.WriteLine("    Ship NOT PLACED! : {0}", r);
                }

            }

        }

        private string GetName(int p)
        {
            if (p == 1) Console.Write("     Player 1 - Please enter your name (if you wish...):  ");
            else Console.Write("\n     Player 2 - Please enter name (if you wish...):  ");
            return Console.ReadLine();
        }
    }
}
