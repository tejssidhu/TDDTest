using System;
using System.Collections.Generic;
using RandomNumberString.Interfaces;

namespace RandomNumberString
{
    public class RandomIntegerListGenerator : IRandomIntegerListGenerator
    {
        public List<int> GetRandomIntegers(int numberOfIntegers, int minValue, int maxValue)
        {
            List<int> myNumbers = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < numberOfIntegers; i++)
                myNumbers.Add(getRandomNumber(minValue, maxValue, rnd));

            return myNumbers;
        }

        private int getRandomNumber(int minValue, int maxValue, Random rnd)
        {
            return rnd.Next(minValue, maxValue);
        }
    }
}
