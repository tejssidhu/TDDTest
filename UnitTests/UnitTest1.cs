using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNumberString;
using RandomNumberString.Interfaces;
using Moq;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void List_Contains_Correct_Number_Of_Items()
        {
            //Arrange
            int numOfIntegers = 8;
            int minValue = 1;
            int maxValue = 100;

            RandomIntegerListGenerator randomIntegerListGenerator = new RandomIntegerListGenerator();

            //Act - system under test randomIntegerStringGenerator.getRandomIntegerString
            List<int> myIntList = randomIntegerListGenerator.GetRandomIntegers(numOfIntegers, minValue, maxValue);

            //Assert
            Assert.AreEqual(numOfIntegers, myIntList.Count);
        }

        [TestMethod]
        public void String_Contains_Comma_Seperated_List_Of_Expected_Numbers()
        {
            //Arrange
            int numOfIntegers = 5;
            int minValue = 1;
            int maxValue = 100;

            var mockRandomListGenerator = new Mock<IRandomIntegerListGenerator>();

            mockRandomListGenerator.Setup(x => x.GetRandomIntegers(numOfIntegers, minValue, maxValue)).Returns(new List<int> { 10, 55, 26, 14, 15 });

            RandomIntegerStringGenerator randomIntegerStringGenerator = new RandomIntegerStringGenerator(mockRandomListGenerator.Object, minValue, maxValue);

            //Act - system under test randomIntegerStringGenerator.getRandomIntegerString
            string myString = randomIntegerStringGenerator.GetRandomIntegerString(numOfIntegers);

            //Assert
            Assert.AreEqual("10,55,26,14,15", myString);
        }
    }
}
