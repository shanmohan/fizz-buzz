using System;
using NUnit.Framework;
using System.Collections;
using FizzBuzz.BusinessLogic;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzProcessorTest
    {

        private IFizzBuzzProcesser fizzBuzz;

        [OneTimeSetUp]
        public void Setup()
        {
            fizzBuzz = new FizzBuzzProcesser();
        }

        [TestCase(0, 5, new string[]{ "0", "1","2","Fizz","4","Buzz" })]
        [TestCase(3, 5, new string[] { "Fizz", "4", "Buzz" })]
        [TestCase(-1, 5, new string[] { })]
        [TestCase(5, 3, new string[] { })]
        public void GetFizzBuzzStringTest(int startIndex, int endIndex, Array output)
        {
            //Arrange
            ArrayList arrayOutput = new ArrayList();
            arrayOutput.AddRange(output);

            //Act
            var result = fizzBuzz.GetFizzBuzzString(startIndex, endIndex);

            //Assert
            CollectionAssert.AreEqual(result, (arrayOutput));
        }

    }
}
