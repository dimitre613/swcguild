using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.Requests;

namespace BattleShip.UI
{
    public class ShipPointer
    {

        private ShipDirection _shipDir;
        private const string l = "L";
        private const string r = "R";
        private const string up = "U";
        private const string dn = "D";
        private bool _isInputValid;
        private const string _invalidInputMessage = "That was not a valid input, please try again...";


        public ShipDirection PointShip(string inMessage)
        {
            while (!_isInputValid)
            {
                Console.Write(inMessage);
                string _userInput = Console.ReadLine();

                if ((string.IsNullOrWhiteSpace(_userInput)) || (_userInput.Length > 1))
                    Console.WriteLine(_invalidInputMessage);

                else
                {
                    if (_userInput.Length == 1)
                    {
                        string c = _userInput.ToUpper();

                        if (c == "L")
                        {
                            _shipDir = ShipDirection.Left;
                            _isInputValid = true;
                        }

                        else if (c == "R")
                        {
                            _shipDir = ShipDirection.Right;
                            _isInputValid = true;
                        }

                        else if (c == "U")
                        {
                            _shipDir = ShipDirection.Up;
                            _isInputValid = true;
                        }

                        else if (c == "D")
                        {
                            _shipDir = ShipDirection.Down;
                            _isInputValid = true;
                        }

                        else Console.WriteLine(_invalidInputMessage + "input not L,R,U,D");
                    }
                }
            }

            return _shipDir;

        }


    }
}

