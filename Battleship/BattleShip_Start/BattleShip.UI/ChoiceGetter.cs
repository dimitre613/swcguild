using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    public class ChoiceGetter
    {

        //dat
        private bool _isInputValid;
        private const string _invalidInputMessage = "That was not a valid input, please try again...";
        private int _validInt;
        //fn
        public int GetChoice(string inMessage)
        {
            int result = 0;

            Console.WriteLine();

            while (!_isInputValid)
            {
                Console.Write(inMessage);
                string _userInput = Console.ReadLine();

                // empty string.IsNullOrEmpty(_userInput) || over three chars
                if ((string.IsNullOrWhiteSpace(_userInput)) || (_userInput.Length > 1))
                    Console.WriteLine(_invalidInputMessage + ""); //ref: nullOrEpmtyOr>1

                // everyting else
                else
                {
                    if (_userInput.Length == 1)
                    {
                        if (int.TryParse(_userInput, out result))
                        {
                            if (result == 1 || result == 2)
                            {
                                _validInt = result;
                                _isInputValid = true;
                            }

                            else Console.WriteLine(_invalidInputMessage + ""); //cantParseOrWrongValue
                        }

                    }
                }
            }

            return _validInt;
        }
    }
}
