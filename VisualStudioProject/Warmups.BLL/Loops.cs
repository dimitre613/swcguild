﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Loops
    {
        /* 1.  Given a string and a non-negative int n, return a 
           larger string that is n copies of the original string. 
        */
        public string StringTimes(string str, int n)
        {
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                result += str;
            }

            return result;
        }


        //2.  Given a string and a non-negative int n, we'll say that the front of 
        //the string is the first 3 chars, or whatever is there if the string is 
        //less than length 3. Return n copies of the front; 

        //FrontTimes("Chocolate", 2) -> "ChoCho"
        //FrontTimes("Chocolate", 3) -> "ChoChoCho"
        //FrontTimes("Abc", 3) -> "AbcAbcAbc"

        public string FrontTimes(string str, int n)
        {
            string result = "";
            string first3 = str.Substring(0, 3);

            for (int i = 0; i < n; i++)
            {
                result += first3;
                // result = result + first 3;
            }
            return result;
        }


        //3.  Count the number of "xx" in the given string. We'll say that 
        //overlapping is allowed, so "xxx" contains 2 "xx". 

        //CountXX("abcxx") -> 1
        //CountXX("xxx") -> 2
        //CountXX("xxxx") -> 3

        public int CountXX(string str)
        {
            int counter = 0;

            for (int i = 0; i <= str.Length - 2; i++)
            {
                if (str.Substring(i, 2) == "xx") counter++;
            }
            return counter;
        }


        //4.  Given a string, return true if the first instance of "x" in the string is 
        //immediately followed by another "x". 

        //DoubleX("axxbb") -> true
        //DoubleX("axaxxax") -> false
        //DoubleX("xxxxx") -> true

        public bool DoubleX(string str)
        {
            string s = "";
            bool result = false; ;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 1).Contains("x"))
                {
                    s = str.Substring(i, 2);
                    break;
                }
            }
            if (s == "xx") result = true;

            return result;
        }


        //5.  Given a string, return a new string made of every other char starting with the first, 
        //so "Hello" yields "Hlo". 

        //EveryOther("Hello") -> "Hlo"
        //EveryOther("Hi") -> "H"
        //EveryOther("Heeololeo") -> "Hello"

        public string EveryOther(string str)
        {

            var sb = new StringBuilder(str.Length); // Specify capacity;

            for (int i = 0; i < str.Length; i += 2)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();

        }


        //6.  Given a non-empty string like "Code" return a string like "CCoCodCode".  
        //(first char, first two, first 3, etc)

        //StringSplosion("Code") -> "CCoCodCode"
        //StringSplosion("abc") -> "aababc"
        //StringSplosion("ab") -> "aab"

        public string StringSplosion(string str)
        {

            string result = "";

            for (int i = 1; i < str.Length + 1; i++)
            {
                result += str.Substring(0, i);
            }

            return result;

        }


        //7.  Given a string, return the count of the number of times that a substring 
        //length 2 appears in the string and also as the last 2 chars of the string, 
        //so "hixxxhi" yields 1 (we won't count the end substring). 

        //CountLast2("hixxhi") -> 1
        //CountLast2("xaxxaxaxx") -> 1
        //CountLast2("axxxaaxx") -> 2

        public int CountLast2(string str)
        {

            int counter = 0;
            string last2 = str.Substring(str.Length - 2, 2);
            string remainder = str.Substring(0, str.Length - 2);

            for (int i = 0; i < remainder.Length - 1; i++)
            {
                if (remainder[i] == last2[0] && remainder[i + 1] == last2[1]) counter++;

            }
            return counter;
        }


        //8.  Given an array of ints, return the number of 9's in the array. 

        //Count9({1, 2, 9}) -> 1
        //Count9({1, 9, 9}) -> 2
        //Count9({1, 9, 9, 3, 9}) -> 3

        public int Count9(int[] numbers)
        {
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9) counter++;

            }
            return counter;


        }


        //9.  Given an array of ints, return true if one of the first 
        //4 elements in the array is a 9. 
        //The array length may be less than 4. 

        //ArrayFront9({1, 2, 9, 3, 4}) -> true
        //ArrayFront9({1, 2, 3, 4, 9}) -> false
        //ArrayFront9({1, 2, 3, 4, 5}) -> false

        public bool ArrayFront9(int[] numbers)
        {
            // index of returns -1 if value is not found or FIRST index of value 
            if (Array.IndexOf(numbers, 9) == -1 || Array.IndexOf(numbers, 9) >= 3) return false;
            return true;
        }


        //10.  Given an array of ints, return true if .. 1, 2, 3, .. 
        //appears in the array somewhere. 

        //Array123({1, 1, 2, 3, 1}) -> true
        //Array123({1, 1, 2, 4, 1}) -> false
        //Array123({1, 1, 2, 1, 2, 3}) -> true

        public bool Array123(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                    return true;
            }

            return false;

        }


        //11.  Given 2 strings, a and b, return the number of the positions where 
        //they contain the same length 2 substring. So "xxcaazz" and "xxbaaz" yields 3, 
        //since the "xx", "aa", and "az" substrings appear in the same place in both strings. 

        //SubStringMatch("xxcaazz", "xxbaaz") -> 3
        //SubStringMatch("abc", "abc") -> 2
        //SubStringMatch("abc", "axc") -> 0

        public int SubStringMatch(string a, string b)
        {
            int counter = 0;
            int loopLenght = 0;

            if (a.Length > b.Length) loopLenght = b.Length;
            else loopLenght = a.Length;

            for (int i = 0; i < loopLenght - 1; i++)
            {
                if (a.Substring(i, 2) == b.Substring(i, 2)) counter++;
            }

            return counter;
        }

        //12.  Given a string, return a version where all the "x" have been removed. 
        //Except an "x" at the very start or end should not be removed. 

        //StringX("xxHxix") -> "xHix"
        //StringX("abxxxcd") -> "abcd"
        //StringX("xabxxxcdx") -> "xabcdx"

        public string StringX(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 || i == str.Length - 1)
                {
                    result += str[i];
                }

                if (str[i] != 'x' && i != 0 && i != str.Length - 1)
                    result += str[i];
            }
            return result;
        }

        //13. Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so 
        //"kittens" yields "kien". 

        //AltPairs("kitten") -> "kien"
        //AltPairs("Chocolate") -> "Chole"
        //AltPairs("CodingHorror") -> "Congrr"

        public string AltPairs(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 || i == 1 || i == 4 || i == 5 || i == 8 || i == 9)
                    result += str[i];

            }

            return result;
        }

        //14.  Suppose the string "yak" is unlucky. Given a string, return a version 
        //where all the "yak" are removed, but the "a" can be any char. 
        //The "yak" strings will not overlap. 

        //DoNotYak("yakpak") -> "pak"
        //DoNotYak("pakyak") -> "pak"
        //DoNotYak("yak123ya") -> "123ya"

        public string DoNotYak(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 3) == "yak") result = str.Remove(i, 3);
            }

            return result;
        }

        //15.  Given an array of ints, return the number of times that two 6's are
        //next to each other in the array. Also count instances where the 
        //second "6" is actually a 7. 

        //Array667({6, 6, 2}) -> 1
        //Array667({6, 6, 2, 6}) -> 1
        //Array667({6, 7, 2, 6}) -> 1

        public int Array667(int[] numbers)
        {
            int counter = 0;

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if ((numbers[i] == 6 && numbers[i + 1] == 6) || (numbers[i] == 6 && numbers[i + 1] == 7))
                    counter++;
            }
            return counter;
        }

        //16. Given an array of ints, we'll say that a triple is a value 
        //appearing 3 times in a row in the array. 
        //Return true if the array does not contain any triples. 

        //NoTriples({1, 1, 2, 2, 1}) -> true
        //NoTriples({1, 1, 2, 2, 2, 1}) -> false
        //NoTriples({1, 1, 1, 2, 2, 2, 1}) -> false

        public bool NoTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                int a = numbers[i], b = numbers[i + 1], c = numbers[i + 2];

                if (a == b && b == c) return false;
            }
            return true;
        }

        //17.  Given an array of ints, return true if it contains a 2, 7, 1 pattern -- a value, 
        //followed by the value plus 5, followed by the value minus 1.

        //Pattern51({1, 2, 7, 1}) -> true
        //Pattern51({1, 2, 8, 1}) -> false
        //Pattern51({2, 7, 1}) -> true

        public bool Pattern51(int[] numbers)
        {

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                int a = numbers[i], b = numbers[i + 1], c = numbers[i + 2];

                if (a == 2 && b == 7 && c == 1) return true;
            }
            return false;

        }
    }
}
