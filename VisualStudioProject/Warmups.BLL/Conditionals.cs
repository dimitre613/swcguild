using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Conditionals
    {
        /* 1.  We have two children, a and b, and the parameters aSmile and 
           bSmile indicate if each is smiling. We are in trouble if they 
           are both smiling or if neither of them is smiling. Return true 
           if we are in trouble. 
        */
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile && bSmile)
                return true;

            if (!aSmile && !bSmile)
                return true;

            return false;
        }

        //  2.  The parameter weekday is true if it is a weekday, 
        //and the parameter vacation is true if we are on vacation. 
        //We sleep in if it is not a weekday or we're on vacation. 
        //Return true if we sleep in. 

        //sleepIn(false, false) -> true
        //sleepIn(true, false) -> false
        //sleepIn(false, true) -> true

        public bool SleepingIn(bool isWeekday, bool isVacation)
        {
            if (!isWeekday || isVacation) return true;
            return false;
        }

        //  3.  Given two int values, return their sum. However, 
        //if the two values are the same, then return double their sum. 

        //SumDouble(1, 2) -> 3
        //SumDouble(3, 2) -> 5
        //SumDouble(2, 2) -> 8

        public int SumDouble(int a, int b)
        {
            int sumResult = 0;

            if (a == b) sumResult = 2 * (a + b);
            else sumResult = a + b;

            return sumResult;

        }

        //  4.  Given an int n, return the absolute value of the difference between n and 21, 
        //except return double the absolute value of the difference if n is over 21. 

        //Diff21(23) -> 4
        //Diff21(10) -> 11
        //Diff21(21) -> 0

        public int Diff21(int n)
        {
            int a = 21;
            int result = Math.Abs(n - 21);
            if (n > a) result = result * 2;
            return result;
        }


        //  5.  We have a loud talking parrot. 
        //The "hour" parameter is the current hour time in the range 0..23. 
        //We are in trouble if the parrot is talking and the hour is before 7 or after 20. 
        //Return true if we are in trouble. 

        //ParrotTrouble(true, 6) -> true
        //ParrotTrouble(true, 7) -> false
        //ParrotTrouble(false, 6) -> false

        public bool ParrotTrouble(bool isTalking, int hour)
        {

            if ((hour < 7 && isTalking) || (hour > 20 && isTalking)) return true;
            else return false;

        }


        //  6.  Given two ints, a and b, return true if one if them is 10 or if their sum is 10. 

        //Makes10(9, 10) -> true
        //Makes10(9, 9) -> false
        //Makes10(1, 9) -> true

        public bool Makes10(int a, int b)
        {

            int sum = a + b;

            if (((a == 10 || b == 10)) || (sum == 10)) return true;
            else return false;
        }

        //  7.  Given an int n, return true if it is within 10 of 100 or 200.
        //Hint: Check out the C# Math class for absolute value

        //NearHundred(103) -> true
        //NearHundred(90) -> true
        //NearHundred(89) -> false


        public bool NearHundred(int n)
        {

            int a = Math.Abs(n - 100);
            int b = Math.Abs(n - 200);

            if (a <= 10 || b <= 10) return true;
            else return false;

        }

        //  8.  Given two int values, return true if one is negative and one is 
        //positive. Except if the parameter "negative" is true, then return 
        //true only if both are negative. 

        //PosNeg(1, -1, false) -> true
        //PosNeg(-1, 1, false) -> true
        //PosNeg(-4, -5, true) -> true



        public bool PosNeg(int a, int b, bool negative)
        {

            if (negative)
            {
                if (a < 0 && b < 0) return true;
            }
            else if (a < 0 || b < 0) return true;

            return false;

        }

        //  9.  Given a string, return a new string where "not " has been added to the front.
        //However, if the string already begins with "not", return the string unchanged.

        //Hint: Look up how to use "SubString" in c#

        //NotString("candy") -> "not candy"
        //NotString("x") -> "not x"
        //NotString("not bad") -> "not bad"

        public string NotString(string s)
        {

            if (s.Length < 3) return "not" + " " + s;

            else if (s.Substring(0, 3) == "not") return s;

            return "not" + " " + s;

        }


        //  10.  Given a non-empty string and an int n, return a new string where the char at index n has been removed. 
        //The value of n will be a valid index of a char in the original string (Don't check for bad index). 

        //MissingChar("kitten", 1) -> "ktten"
        //MissingChar("kitten", 0) -> "itten"
        //MissingChar("kitten", 4) -> "kittn"

        public string MissingChar(string str, int n)
        {
            return str.Remove(n, 1);
        }

        //  11.  Given a string, return a new string where the first and last chars have been exchanged.

        //FrontBack("code") -> "eodc"
        //FrontBack("a") -> "a"
        //FrontBack("ab") -> "ba"

        public string FrontBack(string str)
        {

            if (str.Length == 1) return str;

            else
            {
                string noFront = str.Remove(0, 1);
                string noFrontAndBack = noFront.Remove(noFront.Length - 1, 1);
                string toBack = str.Substring(0, 1);
                string toFront = str.Substring(str.Length - 1, 1);
                return toFront + noFrontAndBack + toBack;
            }

        }

        //  12.  Given a string, we'll say that the front is the first 3 chars of the string. If the string length is less than 3, 
        //the front is whatever is there. Return a new string which is 3 copies of the front. 

        //Front3("Microsoft") -> "MicMicMic"
        //Front3("Chocolate") -> "ChoChoCho"
        //Front3("at") -> "atatat"

        public string Front3(string str)
        {
            if (str.Length < 3) return str + str + str;
            else return str.Substring(0, 3) + str.Substring(0, 3) + str.Substring(0, 3);

        }

        //  13.  Given a string, take the last char and return a new string with the last char 
        //added at the front and back, so "cat" yields "tcatt". The original string will be length 1 or more.

        //ackAround("cat") -> "tcatt"
        //BackAround("Hello") -> "oHelloo"
        //BackAround("a") -> "aaa"

        public string BackAround(string str)
        {
            string result;
            char lastChar = str.Last();

            if (str.Length > 1)
                result = lastChar + str + lastChar;
            else result = str + str + str;

            return result;

        }

        //  14.  Return true if the given non-negative number is a multiple of 3 or a multiple of 5. 
        //Use the % "mod" operator

        //Multiple3or5(3) -> true
        //Multiple3or5(10) -> true
        //Multiple3or5(8) -> false

        public bool Multiple3or5(int number)
        {
            if (number % 3 == 0 || number % 5 == 0) return true;
            return false;
        }

        //  15.  Given a string, return true if the string starts with "hi" and 
        //false otherwise.

        //StartHi("hi there") -> true
        //StartHi("hi") -> true
        //StartHi("high up") -> false

        public bool StartHi(string str)
        {
            if (str.Length == 2 && str == "hi") return true;
            if (str.Substring(0, 3) == "hi ") return true;
            return false;
        }

        //  16.  Given two temperatures, return true if one is less than 0 and the other is greater than 100. 

        //IcyHot(120, -1) -> true
        //IcyHot(-1, 120) -> true
        //IcyHot(2, 120) -> false

        public bool IcyHot(int inTemp1, int inTemp2)
        {
            if ((inTemp1 < 0 && inTemp2 > 100) || (inTemp2 < 0 && inTemp1 > 100)) return true;
            else return false;
        }

        //  17.  Given 2 int values, return true if either of them is in the range 10..20 inclusive.

        //Between10and20(12, 99) -> true
        //Between10and20(21, 12) -> true
        //Between10and20(8, 99) -> false

        public bool Between10and20(int input1, int input2)
        {
            if ((input1 >= 10 && input1 <= 20) || (input2 >= 10 && input2 <= 20)) return true;
            return false;
        }

        //  18. We'll say that a number is "teen" if it is in the range 13..19 inclusive. 
        //Given 3 int values, return true if 1 or more of them are teen. 

        //HasTeen(13, 20, 10) -> true
        //HasTeen(20, 19, 10) -> true
        //HasTeen(20, 10, 12) -> false

        public bool HasTeen(int a, int b, int c)
        {
            if ((a >= 13 && a <= 19) || (b >= 13 && b <= 19) || (c >= 13 && c <= 19))
                return true;
            return false;
        }

        //  19.  We'll say that a number is "teen" if it is in the range 13..19 inclusive. 
        //Given 2 int values, return true if one or the other is teen, but not both.

        //SoAlone(13, 99) -> true
        //SoAlone(21, 19) -> true
        //SoAlone(13, 13) -> false

        public bool SoAlone(int a, int b)
        {
            if (((a >= 13 && a <= 19) && (b >= 13 && b <= 19)) || ((a < 13 || a > 19) && (b < 13 || b > 19)))
                return false;
            else return true;

        }


        //  20.  Given a string, if the string "del" appears starting at index 1, return a string
        //where that "del" has been deleted.Otherwise, return the string unchanged.

        //RemoveDel("adelbc") -> "abc"
        //RemoveDel("adelHello") -> "aHello"
        //RemoveDel("adedbc") -> "adedbc"

        public string RemoveDel(string inString)
        {
            string del = "del";
            string s0 = inString.Substring(1, 3);

            if (inString.Length <= 3)
                return inString;

            else if (inString.Length > 3 && (s0.Equals(del, StringComparison.CurrentCultureIgnoreCase)))
                return inString.Remove(1, 3);

            else return inString;

        }

        //  21. Return true if the given string begins with "*ix", the '*' can be anything, 
        //so "pix", "9ix" .. all count.

        //IxStart("mix snacks") -> true
        //IxStart("pix snacks") -> true
        //IxStart("piz snacks") -> false

        public bool IxStart(string inString)
        {
            string ix = "ix";
            string s0 = inString.Substring(1, 2);

            if (inString.Length <= 1)
                return false;

            else if (inString.Length >= 2 && (s0.Equals(ix, StringComparison.CurrentCultureIgnoreCase)))
                return true;

            else return false;

        }

        //  22.  Given a string, return a string made of the first 2 chars(if present), however include first char only if it 
        //is 'o' and include the second only if it is 'z', so "ozymandias" yields "oz". 

        //StartOz("ozymandias") -> "oz"
        //StartOz("bzoo") -> "z"
        //StartOz("oxx") -> "o"

        public string StartOz(string str)
        {
            string oz = "oz";
            string firstChar = str.Substring(0, 1);
            string secChar = str.Substring(1, 1);

            if (str.Length < 2) return str;
            else if (firstChar + secChar == oz) return oz;
            else
            {
                if (firstChar == "o") return "o";
                else if (secChar == "z") return "z";
            }

            return str;
        }

        //  23. Given three int values, a b c, return the largest.

        //Max(1, 2, 3) -> 3
        //Max(1, 3, 2) -> 3
        //Max(3, 2, 1) -> 3

        public int Max(int a, int b, int c)
        {
            IEnumerable<int> numbers = new List<int>() { a, b, c };
            var max = numbers.Max();
            return max;
        }

        //  24. Given 2 int values, return whichever value is nearest to the value 10, or 
        //return 0 in the event of a tie.

        //Closer(8, 13) -> 8
        //Closer(13, 8) -> 8
        //Closer(13, 7) -> 0

        public int Closer(int a, int b)
        {
            int diff = Math.Abs(10 - a);
            int diff1 = Math.Abs(10 - b);

            if (diff < diff1) return a;
            if (diff > diff1) return b;
            else return 0;

        }


        //  25. Return true if the given string contains between 1 and 3 'e' chars.

        //GotE("Hello") -> true
        //GotE("Heelle") -> true
        //GotE("Heelele") -> false

        public bool GotE(string str)
        {
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, 1) == "e") counter++;
            }

        
            if (counter > 0 && counter <= 3) return true;
            return false;

        }


        //  26. Given a string, return a new string where the last 3 chars are now in upper case. 
        //If the string has less than 3 chars, uppercase whatever is there.

        //EndUp("Hello") -> "HeLLO"
        //EndUp("hi there") -> "hi thERE"
        //EndUp("hi") -> "HI"

        public string EndUp(string inString)
        {
            if (inString.Length < 3)
                return inString.ToUpper();

            else
            {
                string s1 = inString.Substring(0, inString.Length - 3);
                string s2 = inString.Substring(inString.Length - 3, 3);
                string s3 = s2.ToUpper();
                return s1 + s3;
            }

        }

        //  27.  Given a non-empty string and an int N,
        //return the string made starting with char 0, 
        //and then every Nth char of the string. 
        //So if N is 3, use char 0, 3, 6, ... and so on.N is 1 or more.

        //EveryNth("Miracle", 2) -> "Mrce"
        //EveryNth("abcdefg", 2) -> "aceg"
        //EveryNth("abcdefg", 3) -> "adg"

        public string EveryNth(string inString, int everyNth)
        {
            string firstLetter = inString.Substring(0, 1);
            string result = "";

            for (int i = 0; i < inString.Length; i += everyNth)
            {
                result += inString.Substring(i, 1);
            }
            return result;

        }

    }
}
