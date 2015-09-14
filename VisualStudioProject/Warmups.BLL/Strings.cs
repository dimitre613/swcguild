using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Strings
    {
        // 1.  Given a string name, e.g. "Bob", return a greeting of the form "Hello Bob!". 
        public string SayHi(string name)
        {
            return string.Format("Hello {0}!", name);
        }

        // 2.  Given two strings, a and b, return the result of putting them together in the order abba, e.g. 
        //"Hi" and "Bye" returns "HiByeByeHi". 

        public string Abba(string a, string b)
        {
            return string.Format("{0}{1}{1}{0}", a, b);

        }

        // 3.  The web is built with HTML strings like "<i>Yay</i>" which draws Yay as italic text. 
        //In this example, the "i" tag makes <i> and </i> which surround the word "Yay". 
        //Given tag and word strings, create the HTML string with tags around the word, e.g. "<i>Yay</i>". 

        //MakeTags("i", "Yay") -> "<i>Yay</i>"
        //MakeTags("i", "Hello") -> "<i>Hello</i>"
        //MakeTags("cite", "Yay") -> "<cite>Yay</cite>"


        public string MakeTags(string tag, string content)
        {
            string t1 = "<";
            string t2 = ">";
            string t3 = "/";

            string result = t1 + tag + t2 + content + t1 + t3 + tag + t2;

            return result;

        }


        //  4.  Given an "out" string length 4, such as "<<>>", and a word, return a new string 
        //where the word is in the middle of the out string, e.g. "<<word>>".

        //Hint: Substrings are your friend here 

        //InsertWord("<<>>", "Yay") -> "<<Yay>>"
        //InsertWord("<<>>", "WooHoo") -> "<<WooHoo>>"
        //InsertWord("[[]]", "word") -> "[[word]]"


        public string InsertWord(string container, string word)
        {

            string c1 = container.Substring(0, 2);
            string c2 = container.Substring(2);
            string result = c1 + word + c2;
            return result;

        }


        //  5.  Given a string, return a new string made of 3 copies of the last 2 chars of the original string. 
        //The string length will be at least 2. 

        //MultipleEndings("Hello") -> "lololo"
        //MultipleEndings("ab") -> "ababab"
        //MultipleEndings("Hi") -> "HiHiHi"

        public string MultipleEndings(string str)
        {
            string r1 = str.Substring(str.Length - 2);
            return r1 + r1 + r1;
        }

        //  6.  Given a string of even length, return the first half. So the string "WooHoo" yields "Woo". 

        //FirstHalf("WooHoo") -> "Woo"
        //FirstHalf("HelloThere") -> "Hello"
        //FirstHalf("abcdef") -> "abc"


        public string FirstHalf(string word)
        {
            int lenght = word.Length;
            int half = lenght / 2;

            string result = word.Substring(0, half);

            return result;
        }

        //  7.  Given a string, return a version without the first and last char, so "Hello" yields "ell". 
        //The string length will be at least 2. 

        //TrimOne("Hello") -> "ell"
        //TrimOne("java") -> "av"
        //TrimOne("coding") -> "odin"


        public string TrimOne(string str)
        {
            string r1 = str.Remove(0, 1);
            string r2 = r1.Remove(r1.Length - 1);
            return r2;
        }

        //  8.  Given 2 strings, a and b, return a string of the form short+long+short, 
        //with the shorter string on the outside and the longer string on the inside. 
        //The strings will not be the same length, but they may be empty (length 0). 

        //LongInMiddle("Hello", "hi") -> "hiHellohi"
        //LongInMiddle("hi", "Hello") -> "hiHellohi"
        //LongInMiddle("aaa", "b") -> "baaab"


        public string LongInMiddle(string a, string b)
        {

            string firstLast = "";
            string middle = "";

            if (a.Length > b.Length)
            {
                middle = a;
                firstLast = b;
            }

            else

            {
                middle = b;
                firstLast = a;
            }

            return firstLast + middle + firstLast;

        }

        //  9.  Given a string, return a "rotated left 2" version where the first 2 chars are moved to the end. 
        //The string length will be at least 2. 

        //Rotateleft2("Hello") -> "lloHe"
        //Rotateleft2("java") -> "vaja"
        //Rotateleft2("Hi") -> "Hi"


        public string Rotateleft2(string word)
        {

            string first2Char = word.Substring(0, 2);

            string restOfWord = word.Substring(2);

            string result = restOfWord + first2Char;

            return result;

        }



        //  10.  Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start. 
        //The string length will be at least 2. 

        //RotateRight2("Hello") -> "loHel"
        //RotateRight2("java") -> "vaja"
        //RotateRight2("Hi") -> "Hi"


        public string RotateRight(string word)
        {

            string lest2Char = word.Substring(word.Length - 2);

            string restOfWord = word.Substring(0, word.Length - 2);

            string result = lest2Char + restOfWord;

            return result;
        }


        //  11.  Given a string, return a string length 1 from its front, unless front is false, 
        //in which case return a string length 1 from its back. The string will be non-empty. 

        //TakeOne("Hello", true) -> "H"
        //TakeOne("Hello", false) -> "o"
        //TakeOne("oh", true) -> "o"


        public string TakeOne(string word, bool fromFront)
        {
            if (fromFront == false)
                return word.Substring(word.Length - 1);
            else return word.Substring(0, 1);

        }

        //  12.  Given a string of even length, return a string made of the middle two chars, 
        //so the string "string" yields "ri". The string length will be at least 2. 

        //MiddleTwo("string") -> "ri"
        //MiddleTwo("code") -> "od"
        //MiddleTwo("Practice") -> "ct"


        public string MiddleTwo(string word)
        {
            int middleStartPos = (word.Length) / 2;

            string result = word.Substring(middleStartPos - 1, 2);

            return result;

        }

        //  13.  Given a string, return true if it ends in "ly". 

        //EndsWithLy("oddly") -> true
        //EndsWithLy("y") -> false
        //EndsWithLy("oddy") -> false


        public bool EndsWithLy(string word)
        {
            bool result = false;
            if (word.Length < 2)
                result = false;

            else if (word.Length >= 2)
            {
                string s1 = word.Substring(word.Length - 2);
                if (s1 == "ly") result = true;

                else result = false;
            }

            return result;
        }


        //  14.  Given a string and an int n, return a string made of the first and last n chars from the string. 
        //The string length will be at least n. 

        //FrontAndBack("Hello", 2) -> "Helo"
        //FrontAndBack("Chocolate", 3) -> "Choate"
        //FrontAndBack("Chocolate", 1) -> "Ce"


        public string FrontAndBack(string word, int firstLastN)
        {
            string firstPart = word.Substring(0, firstLastN);
            string lastPart = word.Substring(word.Length - firstLastN);
            return firstPart + lastPart;

        }

        //  15.  Given a string and an index, return a string length 2 starting at the given index. 
        //If the index is too big or too small to define a string length 2, use the first 2 chars. 
        //The string length will be at least 2. 

        //TakeTwoFromPosition("java", 0) -> "ja"
        //TakeTwoFromPosition("java", 2) -> "va"
        //TakeTwoFromPosition("java", 3) -> "ja"


        public string TakeTwoFromPosition(string word, int index)
        {
            string result = "";

            int tLenght = word.Length;
            int pos = index + 1;

            if ((tLenght - index) >= 2) result = word.Substring(index, 2);
            else result = word.Substring(0, 2);

            return result;

        }

        //  16.  Given a string, return true if "bad" appears starting at index 0 or 1 in the string, 
        //such as with "badxxx" or "xbadxx" but not "xxbadxx". The string may be any length, including 0.

        //HasBad("badxx") -> true
        //HasBad("xbadxx") -> true
        //HasBad("xxbadxx") -> false


        public bool HasBad(string word)
        {

            if (word.Length < 3) return false;

            if ((word.Length == 3) && (word.Substring(0) == "bad")) return true;

            if (word.Length > 3)
            {
                string s1 = word.Substring(0, 3);
                string s2 = word.Substring(1, 3);
                if (s1 == "bad" || s2 == "bad") return true;
                else return false;
            }

            else return false;


        }

        //  17.  Given a string, return a string length 2 made of its first 2 chars. 
        //If the string length is less than 2, use '@' for the missing chars. 

        //AtFirst("hello") -> "he"
        //AtFirst("hi") -> "hi"
        //AtFirst("h") -> "h@"


        public string AtFirst(string word)
        {
            if (word.Length < 2) return word + "@";

            else return word.Substring(0, 2);
        }


        //  18.  Given 2 strings, a and b, return a new string made of the first char of a and the last char of b, 
        //so "yo" and "java" yields "ya". If either string is length 0, use '@' for its missing char. 

        //LastChars("last", "chars") -> "ls"
        //LastChars("yo", "mama") -> "ya"
        //LastChars("hi", "") -> "h@"


        public string LastChars(string s1, string s2)
        {
            if (s1.Length == 0 && s2.Length != 0) return s2.Substring(0, 1) + "@";
            if (s2.Length == 0 && s1.Length != 0) return s1.Substring(0, 1) + "@";
            if (s1.Length == 0 && s2.Length == 0) return "@" + "@";
            else return s1.Substring(0, 1) + s2.Substring(s2.Length - 1, 1);

        }


        //  19.  Given two strings, append them together (known as "concatenation") and return the result. 
        //However, if the concatenation creates a double-char, 
        //then omit one of the chars, so "abc" and "cat" yields "abcat". 

        //ConCat("abc", "cat") -> "abcat"
        //ConCat("dog", "cat") -> "dogcat"
        //ConCat("abc", "") -> "abc"


        public string ConCat(string s1, string s2)
        {
            if (s1 != "" && s2 != "")
            {
                string lastFirst = s1.Substring(s1.Length - 1, 1);
                string firstLast = s2.Substring(0, 1);
                if (lastFirst == firstLast) return s1 + s2.Substring(1);
                else return s1 + s2;
            }

            return s1 + s2;

        }

        //  20.  Given a string of any length, return a new string where the last 2 chars, 
        //if present, are swapped, so "coding" yields "codign". 

        //SwapLast("coding") -> "codign"
        //SwapLast("cat") -> "cta"
        //SwapLast("ab") -> "ba"


        public string SwapLast(string word)
        {
            if (word.Length < 2) return word;
            else
            {
                string s1 = word.Substring(0, word.Length - 2);
                string s2 = word.Substring(word.Length - 2, 1);
                string s3 = word.Substring(word.Length - 1);
                return s1 + s3 + s2;
            }

        }

        //  21.  Given a string, return true if the first 2 chars in the string also appear at the end of the string, 
        //such as with "edited". 
        public bool FrontAgain(string word)
        {
            string first2 = word.Substring(0, 2);
            string last2 = word.Substring(word.Length - 2, 2);

            if (first2 == last2) return true;
            return false;
        }

        //  22.  Given two strings, append them together (known as "concatenation") and return the result. 
        //However, if the strings are different lengths, omit chars from the longer string so it is 
        //the same length as the shorter string. So "Hello" and "Hi" yield "loHi". The strings may be any length. 


        public string MinCat(string a, string b)
        {
            if (a.Length != b.Length)
            {
                if (a.Length > b.Length) return a.Substring(a.Length - b.Length) + b;
                else return a + b.Substring(b.Length - a.Length);
            }
            return a + b;
        }


        //  23.  Given a string, return a version without the first 2 chars. 
        //Except keep the first char if it is 'a' and keep the second char if it is 'b'. 
        //The string may be any length.



        public string TweakFront(string c)
        {
            if (c.Substring(0, 1) == "a" && c.Substring(1, 1) != "b")
                return c.Substring(0, 1) + c.Substring(2);

            if (c.Substring(0, 1) == "a" && c.Substring(1, 1) == "b") return c;
            if (c.Substring(1, 1) == "b" && c.Substring(0, 1) != "a") return c.Substring(1);
            return c.Substring(2);

        }

        //  24.  Given a string, if the first or last chars are 'x', 
        //return the string without those 'x' chars, 
        //and otherwise return the string unchanged. 

        public string StripX(string c)
        {
            if (c.Substring(0, 1) == "x" && c.Substring(c.Length - 1) == "x")
            {
                string r1 = c.Remove(0, 1);
                string r2 = r1.Remove(r1.Length - 1, 1);
                return r2;
            }

            if (c.Substring(0, 1) == "x" && c.Substring(c.Length - 1) != "x")
            {
                return c.Substring(1);
            }

            if (c.Substring(0, 1) != "x" && c.Substring(c.Length - 1) == "x")
            {

                string r2 = c.Remove(c.Length - 1, 1);
                return r2;
            }


            return c;

        }
    }
}
