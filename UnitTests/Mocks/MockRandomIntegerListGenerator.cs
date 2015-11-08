using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNumberString.Interfaces;

namespace UnitTests.Mocks
{
    public class MockRandomIntegerListGenerator : IRandomIntegerListGenerator
    {
        public List<int> getRandomIntegers(int numberOfIntegers, int minValue, int maxValue)
        {
            return new List<int> { 10, 55, 26, 14, 15 };
        }
    }
}
