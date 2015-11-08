using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNumberString;
using RandomNumberString.Interfaces;
using UnitTests.Mocks;
using Moq;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void String_Contains_Comma_Seperated_List_Of_Expected_Numbers()
        {
            //Arrange
            var mockRandomListGenerator = new Mock<IRandomIntegerListGenerator>();

            mockRandomListGenerator.Setup(x => x.getRandomIntegers(5, 1, 100)).Returns(new List<int> { 10, 55, 26, 14, 15 });

            RandomIntegerStringGenerator randomIntegerStringGenerator = new RandomIntegerStringGenerator(mockRandomListGenerator.Object, 1, 100);

            //Act - system under test randomIntegerStringGenerator.getRandomIntegerString
            string myString = randomIntegerStringGenerator.getRandomIntegerString(5);

            //Assert
            Assert.AreEqual("10,55,26,14,15", myString);
        }
    }
}
