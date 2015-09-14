using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class ArrayTests
    {
        [TestCase(new int[] { 1, 2, 6 }, true)]
        [TestCase(new int[] { 6, 1, 2, 3 }, true)]
        [TestCase(new int[] { 13, 6, 1, 2, 3 }, false)]
        public void FirstLast6Test(int[] numbers, bool expected)
        {
            // arrange
            Arrays obj = new Arrays();

            // act
            bool actual = obj.FirstLast6(numbers);

            // assert
            Assert.AreEqual(expected, actual);
        }

        //SameFirstLast({1, 2, 3}) -> false
        //SameFirstLast({ 1, 2, 3, 1}) -> true
        //SameFirstLast({ 1, 2, 1}) -> true

        [TestCase(new int[] { 1, 2, 3 }, false)]
        [TestCase(new int[] { 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 2, 1 }, true)]

        public void SameFirstLast(int[] numbers, bool expected)
        {

            Arrays obj = new Arrays();
            bool actual = obj.SameFirstLast(numbers);
            Assert.AreEqual(expected, actual);
        }

        //MakePi(3) -> {3, 1, 4}

        [TestCase(3, new int[] { 3, 1, 4 })]
        [TestCase(5, new int[] { 3, 1, 4, 1, 5 })]

        public void MakePi(int a, int[] expected)
        {

            Arrays obj = new Arrays();
            int[] actual = obj.MakePi(a);
            Assert.AreEqual(expected, actual);
        }

        //CommonEnd({1, 2, 3}, {7, 3}) -> true
        //CommonEnd({1, 2, 3}, {7, 3, 2}) -> false
        //CommonEnd({1, 2, 3}, {1, 3}) -> true
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3 }, true)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3, 2 }, false)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 3 }, true)]

        public void CommonEnd(int[] a, int[] b, bool expected)
        {

            Arrays obj = new Arrays();
            bool actual = obj.CommonEnd(a, b);
            Assert.AreEqual(expected, actual);
        }

        //Sum({ 1, 2, 3}) -> 6
        //Sum({ 5, 11, 2}) -> 18
        //Sum({ 7, 0, 0}) -> 7

        [TestCase(new int[] { 1, 2, 3 }, 6)]
        [TestCase(new int[] { 5, 11, 2 }, 18)]
        [TestCase(new int[] { 7, 0, 0 }, 7)]

        public void Sum(int[] numbers, int expected)
        {
            Arrays obj = new Arrays();
            int actual = obj.Sum(numbers);
            Assert.AreEqual(expected, actual);
        }



        //RotateLeft({1, 2, 3}) -> {2, 3, 1}
        //RotateLeft({5, 11, 9}) -> {11, 9, 5}
        //RotateLeft({7, 0, 0}) -> {0, 0, 7}
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3, 1 })]
        [TestCase(new int[] { 5, 11, 9 }, new int[] { 11, 9, 5 })]
        [TestCase(new int[] { 7, 0, 0 }, new int[] { 0, 0, 7 })]

        public void RotateLeft(int[] a, int[] expected)
        {

            Arrays obj = new Arrays();
            int[] actual = obj.RotateLeft(a);
            Assert.AreEqual(expected, actual);
        }

        //example {1, 2, 3} becomes {3, 2, 1}.
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        public void Reverse(int[] a, int[] expected)
        {

            Arrays obj = new Arrays();
            int[] actual = obj.Reverse(a);
            Assert.AreEqual(expected, actual);
        }

        //HigherWins({1, 2, 3}) -> {3, 3, 3}
        //HigherWins({11, 5, 9}) -> {11, 11, 11}
        //HigherWins({2, 11, 3}) -> {3, 3, 3}

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 3, 3 })]

        public void HigherWins(int[] a, int[] expected)
        {

            Arrays obj = new Arrays();
            int[] actual = obj.HigherWins(a);
            Assert.AreEqual(expected, actual);
        }

        //GetMiddle({ 1, 2, 3}, {4, 5, 6}) -> {2, 5}
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4,5,6 }, new int[] {2,5 })]

        public void GetMiddle(int[] a, int[] b, int[] expected)
        {

            Arrays obj = new Arrays();
            int[] actual = obj.GetMiddle(a,b);
            Assert.AreEqual(expected, actual);
        }


        //HasEven({2, 5}) -> true
        //HasEven({4, 3}) -> true
        //HasEven({7, 5}) -> false
        [TestCase(new int[] { 2,5}, true)]
        [TestCase(new int[] { 4,3 }, true)]
        [TestCase(new int[] { 7,5 }, false)]

        public void HasEven(int[] numbers, bool expected)
        {

            Arrays obj = new Arrays();
            bool actual = obj.HasEven(numbers);
            Assert.AreEqual(expected, actual);
        }

        //KeepLast({ 4, 5, 6}) -> {0, 0, 0, 0, 0, 6}
        //KeepLast({ 1, 2}) -> {0, 0, 0, 2}
        //KeepLast({ 3}) -> {0, 3}

        [TestCase(new int[] { 4,5,6 }, new int[] { 0,0,0,0,0,6 })]
        [TestCase(new int[] { 1,2 }, new int[] { 0,0,0,2 })]
        [TestCase(new int[] { 3 }, new int[] { 0, 3 })]

        public void KeepLast(int[] a, int[] expected)
        {

            Arrays obj = new Arrays();
            int[] actual = obj.KeepLast(a);
            Assert.AreEqual(expected, actual);
        }
        //Double23({2, 2, 3}) -> true
        //Double23({ 3, 4, 5, 3}) -> true
        //Double23({ 2, 3, 2, 2}) -> false

        [TestCase(new int[] { 2,2,3 }, true)]
        [TestCase(new int[] { 3,4,5,3 }, true)]
        [TestCase(new int[] { 2,3,2,2 }, false)]

        public void Double23(int[] numbers, bool expected)
        {

            Arrays obj = new Arrays();
            bool actual = obj.Double23(numbers);
            Assert.AreEqual(expected, actual);
        }



        //Fix23({1, 2, 3}) -> {1, 2, 0}
        //Fix23({2, 3, 5}) -> {2, 0, 5}
        //Fix23({1, 2, 1}) -> {1, 2, 1}

        [TestCase(new int[] { 1,2,3 }, new int[] { 1,2,0 })]
        [TestCase(new int[] { 2,3,5 }, new int[] { 2,0,5 })]
        [TestCase(new int[] { 1,2,1 }, new int[] { 1,2,1 })]

        public void Fix23(int[] a, int[] expected)
        {
            Arrays obj = new Arrays();
            int[] actual = obj.Fix23(a);
            Assert.AreEqual(expected, actual);
        }


        //Unlucky1({1, 3, 4, 5}) -> true
        //Unlucky1({2, 1, 3, 4, 5}) -> true
        //Unlucky1({1, 1, 1}) -> false

        [TestCase(new int[] {1,3,4,5 }, true)]
        [TestCase(new int[] { 2,1,3,4,5 }, true)]
        [TestCase(new int[] { 1,1,1 }, false)]

        public void Unlucky1(int[] numbers, bool expected)
        {

            Arrays obj = new Arrays();
            bool actual = obj.Unlucky1(numbers);
            Assert.AreEqual(expected, actual);
        }



        //Make2({4, 5}, {1, 2, 3}) -> {4, 5}
        //Make2({4}, {1, 2, 3}) -> {4, 1}
        //Make2({}, {1, 2}) -> {1, 2}
        [TestCase(new int[] { 4,5 }, new int[] { 1,2,3 }, new int[] { 4, 5 })]
        [TestCase(new int[] { 4 }, new int[] { 1, 2, 3 }, new int[] { 4, 1 })]
        [TestCase(new int[] { }, new int[] { 1, 2}, new int[] { 1,2 })]

        public void Make2(int[] a, int[] b, int[] expected)
        {

            Arrays obj = new Arrays();
            int[] actual = obj.Make2(a, b);
            Assert.AreEqual(expected, actual);
        }




    }
}
