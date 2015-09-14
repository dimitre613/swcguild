using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class ConditionalTests
    {
        //1
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void AreWeInTroubleTest(bool aSmile, bool bSmile, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.AreWeInTrouble(aSmile, bSmile);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //2.  sleepIn(false, false) -> true
        //sleepIn(true, false) -> false
        //sleepIn(false, true) -> true

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]

        public void SleepIn(bool a, bool b, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.SleepingIn(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //3.  SumDouble(1, 2) -> 3
        //SumDouble(3, 2) -> 5
        //SumDouble(2, 2) -> 8

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]

        public void SumDouble(int a, int b, int expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            int actual = obj.SumDouble(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //4.  Diff21(23) -> 4
        //Diff21(10) -> 11
        //Diff21(21) -> 0

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]

        public void Diff21(int a, int expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            int actual = obj.Diff21(a);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //5.  ParrotTrouble(true, 6) -> true
        //ParrotTrouble(true, 7) -> false
        //ParrotTrouble(false, 6) -> false

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]

        public void ParrotTrouble(bool a, int b, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.ParrotTrouble(a, b);

            // assert
            Assert.AreEqual(expected, actual);

        }

        //6.  Makes10(9, 10) -> true
        //Makes10(9, 9) -> false
        //Makes10(1, 9) -> true

        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]

        public void Makes10(int a, int b, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.Makes10(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //7.  NearHundred(103) -> true
        //NearHundred(90) -> true
        //NearHundred(89) -> false

        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]

        public void NearHundred(int a, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.NearHundred(a);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //8. PosNeg(1, -1, false) -> true
        //PosNeg(-1, 1, false) -> true
        //PosNeg(-4, -5, true) -> true


        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]

        public void PosNeg(int a, int b, bool c, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.PosNeg(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //9.  NotString("candy") -> "not candy"
        //NotString("x") -> "not x"
        //NotString("not bad") -> "not bad"

        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]

        public void NotString(string a, string expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            string actual = obj.NotString(a);

            // assert
            Assert.AreEqual(expected, actual);
        }


        //10.  MissingChar("kitten", 1) -> "ktten"
        //MissingChar("kitten", 0) -> "itten"
        //MissingChar("kitten", 4) -> "kittn"

        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]

        public void MissingChar(string a, int b, string expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            string actual = obj.MissingChar(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }


        //11.  FrontBack("code") -> "eodc"
        //FrontBack("a") -> "a"
        //FrontBack("ab") -> "ba"

        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]

        public void FrontBack(string a, string expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            string actual = obj.FrontBack(a);

            // assert
            Assert.AreEqual(expected, actual);
        }


        //12. Front3("Microsoft") -> "MicMicMic"
        //Front3("Chocolate") -> "ChoChoCho"
        //Front3("at") -> "atatat"

        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at", "atatat")]

        public void Front3(string a, string expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            string actual = obj.Front3(a);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //13.  BackAround("cat") -> "tcatt"
        //BackAround("Hello") -> "oHelloo"
        //BackAround("a") -> "aaa"

        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]

        public void BackAround(string a, string expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            string actual = obj.BackAround(a);

            // assert
            Assert.AreEqual(expected, actual);
        }



        //14.  Multiple3or5(3) -> true
        //Multiple3or5(10) -> true
        //Multiple3or5(8) -> false

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(8, false)]

        public void Multople3or5(int a, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.Multiple3or5(a);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //15. StartHi("hi there") -> true
        //StartHi("hi") -> true
        //StartHi("high up") -> false

        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("high up", false)]

        public void StartHi(string a, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.StartHi(a);
            // assert
            Assert.AreEqual(expected, actual);
        }

        //16.  IcyHot(120, -1) -> true
        //IcyHot(-1, 120) -> true
        //IcyHot(2, 120) -> false

        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]

        public void IcyHot(int a, int b, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.IcyHot(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //17. Between10and20(12, 99) -> true
        //Between10and20(21, 12) -> true
        //Between10and20(8, 99) -> false

        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]

        public void Between10and20(int a, int b, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.Between10and20(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //18.  HasTeen(13, 20, 10) -> true
        //HasTeen(20, 19, 10) -> true
        //HasTeen(20, 10, 12) -> false

        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 10, false)]

        public void HasTeen(int a, int b, int c, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.HasTeen(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //19. SoAlone(13, 99) -> true
        //SoAlone(21, 19) -> true
        //SoAlone(13, 13) -> false

        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]

        public void SoAlone(int a, int b, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.SoAlone(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //20.  RemoveDel("adelbc") -> "abc"
        //RemoveDel("adelHello") -> "aHello"
        //RemoveDel("adedbc") -> "adedbc"

        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]

        public void RemoveDel(string a, string expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            string actual = obj.RemoveDel(a);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //21.  IxStart("mix snacks") -> true
        //IxStart("pix snacks") -> true
        //IxStart("piz snacks") -> false

        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]

        public void IxStart(string a, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.IxStart(a);
            // assert
            Assert.AreEqual(expected, actual);
        }

        //22.  StartOz("ozymandias") -> "oz"
        //StartOz("bzoo") -> "z"
        //StartOz("oxx") -> "o"

        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]

        public void StartOz(string a, string expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            string actual = obj.StartOz(a);

            // assert
            Assert.AreEqual(expected, actual);
        }


        //23.  Max(1, 2, 3) -> 3
        //Max(1, 3, 2) -> 3
        //Max(3, 2, 1) -> 3

        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]

        public void Max(int a, int b, int c, int expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            int actual = obj.Max(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //24.  Closer(8, 13) -> 8
        //Closer(13, 8) -> 8
        //Closer(13, 7) -> 0

        [TestCase(8, 13, 8)]
        [TestCase(13, 8, 8)]
        [TestCase(13, 7, 0)]

        public void Closer(int a, int b, int expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            int actual = obj.Closer(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //25. GotE("Hello") -> true
        //GotE("Heelle") -> true
        //GotE("Heelele") -> false

        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]

        public void GotE(string a, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.GotE(a);
            // assert
            Assert.AreEqual(expected, actual);
        }

        //26.  EndUp("Hello") -> "HeLLO"
        //EndUp("hi there") -> "hi thERE"
        //EndUp("hi") -> "HI"

        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]

        public void EndUp(string a, string expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            string actual = obj.EndUp(a);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //27.  EveryNth("Miracle", 2) -> "Mrce"
        //EveryNth("abcdefg", 2) -> "aceg"
        //EveryNth("abcdefg", 3) -> "adg"

        [TestCase("Miracle",2, "Mrce")]
        [TestCase("abcdefg",2, "aceg")]
        [TestCase("abcdefg",3, "adg")]

        public void EveryNth(string a, int b, string expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            string actual = obj.EveryNth(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }

    }

}

