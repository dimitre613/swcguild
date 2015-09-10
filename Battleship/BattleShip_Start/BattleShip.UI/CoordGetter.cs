using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.Requests;

namespace BattleShip.UI
{
    public class CoordGetter
    {

//dat
        private Coordinate _coordinate { get; set; }
        private const string _alphabet = "ABCDEFGHIJ";
        private bool _isInputValid;
        private const string _invalidInputMessage = "That was not a valid input, please try again...";
        private bool _is2CharLegal = false;
        private bool _is3CharLegal = false;     
        private int _validXCord;
        private int _validYCord;
      
// ctor
        public CoordGetter()
        {
            this._coordinate = new Coordinate(0, 0);
        }

//fn
        public Coordinate GetCoord(string inMessgToUser)
        {
            Console.WriteLine();
            while (!_isInputValid)
            {
                Console.Write(inMessgToUser);
                string _userInput = Console.ReadLine();

                // empty string.IsNullOrEmpty(_userInput) || over three chars
                if ((string.IsNullOrWhiteSpace(_userInput)) || (_userInput.Length > 3) || (_userInput.Length < 2))
                    Console.WriteLine(_invalidInputMessage+""); //ref: nullOrEpmty


                // everything else
                else
                {
                    if (_userInput.Length == 2)
                    {
                        _is2CharLegal = Get2CharLegal(_userInput[0], _userInput[1]);

                        if (!_is2CharLegal) Console.WriteLine(_invalidInputMessage+""); //s2NotValid

                        else
                        {
                            _validXCord = GetIntPos(_userInput.Substring(0, 1));
                            _validYCord = int.Parse(_userInput.Substring(1, 1));
                            _isInputValid = true;
                        }
                    }

                    else if (_userInput.Length == 3)
                    {
                        _is3CharLegal = Get3CharLegal(_userInput[0], _userInput[1], _userInput[2]);

                        if (!_is3CharLegal) Console.WriteLine(_invalidInputMessage+""); //s3NotValid

                        else
                        {
                            _validXCord = GetIntPos(_userInput.Substring(0, 1));
                            _validYCord = 10;
                            _isInputValid = true;
                        }
                    }

                }

            }

            _coordinate.XCoordinate = _validXCord;
            _coordinate.YCoordinate = _validYCord;
           
            return _coordinate;

        }

//priv
        // need A-J && 10
        private bool Get3CharLegal(char inChar1, char inChar2, char inChar3)
        {
            char v1 = char.ToUpper(inChar1);
            int i = v1;           
            if (((i >= 65 && i <= 74) && (inChar2 == '1')) && (inChar3 == '0')) return true;
            return false;
        }


        // need A-J && 1-9
        private bool Get2CharLegal(char inChar1, char inChar2)
        {
            char v1 = char.ToUpper(inChar1);
            char v2 = char.ToUpper(inChar2);
            int i = v1;
            int j = v2;
            if ((i >= 65 && i <= 74) && (j >= 49 && j <= 57))
                return true;
            return false;
        }


        private int GetIntPos(string inString)
        {

            int result = 0;
            for (int i = 0; i < _alphabet.Length; i++)
            {
                if (char.ToUpper(inString[0]).Equals(_alphabet[i])) result = i + 1;
            }
            return result;
        }
    }
}
