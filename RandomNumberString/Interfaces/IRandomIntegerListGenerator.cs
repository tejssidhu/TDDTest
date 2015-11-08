using System.Collections.Generic;

namespace RandomNumberString.Interfaces
{
    public interface IRandomIntegerListGenerator
    {
        List<int> GetRandomIntegers(int numberOfIntegers, int minValue, int maxValue);
    }
}
