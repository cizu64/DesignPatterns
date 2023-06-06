using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace UnitTestproject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given3ThenFizz()
        {
            //Arrange
            //Act
            var result = FizzBuzz(3);

            //Assert
            Assert.AreEqual("Fizz", result);
        }

        object FizzBuzz(int value)
        {
            return "Fizz";
        }
    }
}
