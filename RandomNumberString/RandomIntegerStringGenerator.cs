using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RandomNumberString.Interfaces;

namespace RandomNumberString
{
    public class RandomIntegerStringGenerator : IRandomIntegerStringGenerator
    {
        private readonly IRandomIntegerListGenerator _randomIntegerListGenerator;
        private readonly int _minValue;
        private readonly int _maxValue;

        public RandomIntegerStringGenerator(IRandomIntegerListGenerator randomIntegerListGenerator, int minValue, int maxValue)
        {
            _randomIntegerListGenerator = randomIntegerListGenerator;
            _minValue = minValue;
            _maxValue = maxValue;
        }

        public string GetRandomIntegerString(int numberOfIntegers)
        {
            StringBuilder sb = new StringBuilder();

            List<int> myIntegerList = _randomIntegerListGenerator.GetRandomIntegers(numberOfIntegers, _minValue, _maxValue);

            myIntegerList.ForEach(x => sb.AppendFormat("{0},",x.ToString()));

            sb.Length--;

            return sb.ToString();
        }
        
    }


}
