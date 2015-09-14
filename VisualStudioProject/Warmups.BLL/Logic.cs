﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Logic
    {
        /* When squirrels get together for a party, they like to have cigars. 
           A squirrel party is successful when the number of cigars is between 
           40 and 60, inclusive. Unless it is the weekend, in which case there is 
           no upper bound on the number of cigars. Return true if the party with 
           the given values is successful, or false otherwise. 
        */
        public bool GreatParty(int cigars, bool isWeekend)
        {
            if (isWeekend)
                return cigars > 40;
            else
                return (cigars >= 40 && cigars <= 60);
        }

        //  2.  You and your date are trying to get a table at a restaurant.
        //The parameter "you" is the stylishness of your clothes, in the range 0..10, and "date" is
        //the stylishness of your date's clothes. The result getting 
        //the table is encoded as an int value with 0=no, 1=maybe, 2=yes. 
        //If either of you is very stylish, 8 or more, then the result is 2 (yes). 
        //With the exception that if either of you has style of 2 or less, then the result is 0 (no). 
        //Otherwise the result is 1 (maybe). 

        //CanHazTable(5, 10) → 2
        //CanHazTable(5, 2) → 0
        //CanHazTable(5, 5) → 1

        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if (yourStyle <= 2 || dateStyle <= 2) return 0;
            else if (yourStyle >= 8 || dateStyle >= 8) return 2;
            else return 1;
        }

        //  3.  The children in Cleveland spend most of the day playing outside.In particular, they play if 
        //the temperature is between 60 and 90 (inclusive). Unless it is summer, then the upper limit is 
        //100 instead of 90. Given an int temperature and a bool isSummer, return true if the children 
        //play and false otherwise.

        //PlayOutside(70, false) → true
        //PlayOutside(95, false) → false
        //PlayOutside(95, true) → true

        public bool PlayOutside(int temp, bool isSummer)
        {
            if (isSummer)
            {
                if (temp >= 60 && temp <= 100) return true;
                else return false;
            }

            if (!isSummer)
            {
                if (temp >= 60 && temp <= 90) return true;
                else return false;
            }

            else return false;
        }


        //  4.  You are driving a little too fast, and a police officer stops you.
        //Write code to compute the result, encoded as an int value: 0=no ticket, 
        //1=small ticket, 2=big ticket. If speed is 60 or less, the result is 0. 
        //If speed is between 61 and 80 inclusive, the result is 1. 
        //If speed is 81 or more, the result is 2. 
        //Unless it is your birthday -- on that day, your speed can be 
        //5 higher in all cases. 

        //CaughtSpeeding(60, false) → 0
        //CaughtSpeeding(65, false) → 1
        //CaughtSpeeding(65, true) → 0

        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (isBirthday)
            {
                if (speed <= 65) return 0;
                if (speed >= 66 && speed <= 85) return 1;
                else return 2;
            }

            if (!isBirthday)
            {
                if (speed <= 60) return 0;
                if (speed >= 61 && speed <= 80) return 1;
                else return 2;
            }

            return 0;
        }


        //  5.  Given 2 ints, a and b, return their sum.However, sums in the 
        //range 10..19 inclusive are forbidden, so in that case just return 20. 

        //SkipSum(3, 4) → 7
        //SkipSum(9, 4) → 20
        //SkipSum(10, 11) → 21

        public int SkipSum(int a, int b)
        {
            int sum = a + b;
            if (sum >= 10 && sum <= 19) return 20;
            else return sum;
        }

        //  6.  Given a day of the week encoded as 0=Sun, 1=Mon, 2=Tue, ...6=Sat, 
        //and a boolean indicating if we are on vacation, return a string of 
        //the form "7:00" indicating when the alarm clock should ring.Weekdays, 
        //the alarm should be "7:00" and on the weekend it should be "10:00". 
        //Unless we are on vacation -- then on weekdays it should be "10:00" 
        //and weekends it should be "off". 

        //AlarmClock(1, false) → "7:00"
        //AlarmClock(5, false) → "7:00"
        //AlarmClock(0, false) → "10:00"

        public string AlarmClock(int day, bool vacation)
        {
            if (vacation)
            {
                if (day == 0 || day == 6)
                    return "10:00";
                else return "off";
            }

            if (!vacation)
            {
                if (day == 0 || day == 6) return "10:00";
                else return "7:00";
            }

            return "off";
        }

        //  7.  The number 6 is a truly great number.Given two int values, a and b, 
        //return true if either one is 6. Or if their sum or difference is 6.

        //LoveSix(6, 4) → true
        //LoveSix(4, 5) → false
        //LoveSix(1, 5) → true

        public bool LoveSix(int a, int b)
        {
            int sum = a + b;
            int diff = a - b;
            if (sum == 6 || diff == 6 || a == 6 || b == 6) return true;
            else return false;
        }


        //  8.  Given a number n, return true if n is in the range 1..10, inclusive.
        //Unless "outsideMode" is true, in which case return true if the number 
        //is less or equal to 1, or greater or equal to 10. 

        //InRange(5, false) → true
        //InRange(11, false) → false
        //InRange(11, true) → true

        public bool InRange(int n, bool outsideMode)
        {
            if (outsideMode)
            {
                if (n <= 1 || n >= 10) return true;
            }

            if (!outsideMode)
            {
                if (n >= 1 && n <= 10) return true;
            }
            return false;

        }

        //  9.  We'll say a number is special if it is a multiple of 11 or if it 
        //is one more than a multiple of 11. Return true if the given 
        //non-negative number is special. Use the % "mod" operator

        //SpecialEleven(22) → true
        //SpecialEleven(23) → true
        //SpecialEleven(24) → false

        public bool SpecialEleven(int n)
        {
            if (n % 11 == 0 || ((n - 1) % 11) == 0) return true;
            return false;
        }


        //  10.  Return true if the given non-negative number is 1 or 2 more than a 
        //multiple of 20. See also: Introduction to Mod

        //Mod20(20) → false
        //Mod20(21) → true
        //Mod20(22) → true

        public bool Mod20(int n)
        {
            {
                if ((n - 1) % 20 == 0 || ((n - 2) % 20) == 0)
                    return true;
                return false;
            }

        }

        //  11.  Return true if the given non-negative number is a multiple of 3 or 5, 
        //but not both.Use the % "mod" operator

        //Mod35(3) → true
        //Mod35(10) → true
        //Mod35(15) → false

        public bool Mod35(int n)
        {
            if (n % 3 == 0 && n % 5 == 0) return false;
            if (n % 3 == 0 || n % 5 == 0) return true;
            return false;
        }


        //  12.  Your cell phone rings.Return true if you should answer it. 
        //Normally you answer, except in the morning you only answer if it is 
        //your mom calling.In all cases, if you are asleep, you do not answer. 

        //AnswerCell(false, false, false) → true
        //AnswerCell(false, false, true) → false
        //AnswerCell(true, false, false) → false

        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep) return false;

            if (!isAsleep)
            {
                if (isMorning && isMom) return true;
                if (isMorning && !isMom) return false;
            }

            return true;

        }


        //  13.  Given three ints, a b c, return true if it is possible to add two 
        //of the ints to get the third.

        //TwoIsOne(1, 2, 3) → true
        //TwoIsOne(3, 1, 2) → true
        //TwoIsOne(3, 2, 2) → false

        public bool TwoIsOne(int a, int b, int c)
        {
            if ((a + b == c) || (a + c == b) || (b + c == a)) return true;
            return false;
        }

        //  14.  Given three ints, a b c, return true if b is greater than a, 
        //and c is greater than b.However, with the exception that if "bOk" 
        //is true, b does not need to be greater than a.

        //AreInOrder(1, 2, 4, false) → true
        //AreInOrder(1, 2, 1, false) → false
        //AreInOrder(1, 1, 2, true) → true

        public bool AreInOrder(int a, int b, int c, bool bOk)
        {

            if (bOk)
            { if (c > b) return true; }

            if (!bOk)
            { if (b > a && c > b) return true; }

            return false;

        }


        //  15.  Given three ints, a b c, return true if they are in strict increasing 
        //order, such as 2 5 11, or 5 6 7, but not 6 5 7 or 5 5 7. 
        //However, with the exception that if "equalOk" is true, equality is 
        //allowed, such as 5 5 7 or 5 5 5. 

        //InOrderEqual(2, 5, 11, false) → true
        //InOrderEqual(5, 7, 6, false) → false
        //InOrderEqual(5, 5, 7, true) → true

        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (equalOk)
            {
                if (a <= b && b <= c) return true;
            }
            if (!equalOk)
            {
                if (a < b && b < c) return true;
            }

            return false;
        }


        //  16.  Given three ints, a b c, return true if two or more of them have the 
        //same rightmost digit.The ints are non-negative.

        //LastDigit(23, 19, 13) → true
        //LastDigit(23, 19, 12) → false
        //LastDigit(23, 19, 3) → true

        public bool LastDigit(int a, int b, int c)
        {
            int r1 = a % 10;
            int r2 = b % 10;
            int r3 = c % 10;

            return (r1 == r2 || r2 == r3 || r1 == r3);

            //string a1 = a.ToString();
            //string b1 = b.ToString();
            //string c1 = c.ToString();

            //string a2 = a1.Substring(a1.Length - 1);
            //string b2 = b1.Substring(b1.Length - 1);
            //string c2 = c1.Substring(c1.Length - 1);

            //if ((a2 == b2 || a2 == c2 || b2 == c2)) return true;
            //return false;

        }

        //  17.  Return the sum of two 6-sided dice rolls, each in the range 1..6. 
        //However, if noDoubles is true, if the two dice show the same value,
        //increment one die to the next value, wrapping around to 1 if its 
        //value was 6. 

        //RollDice(2, 3, true) → 5
        //RollDice(3, 3, true) → 7
        //RollDice(3, 3, false) → 6

        public int RollDice(int die1, int die2, bool noDoubles)
        {
            if (die1 == die2)
                if (noDoubles)
                {
                    if (die2 <= 5) die2++;
                    else die2 = 1;
                }

            return die1 + die2;

        }

    }
}

