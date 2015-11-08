using System;
using System.Collections.Generic;

namespace RandomNumberString.Interfaces
{
    public interface IRandomIntegerListGenerator
    {
        List<int> getRandomIntegers(int numberOfIntegers, int minValue, int maxValue);
    }
}
