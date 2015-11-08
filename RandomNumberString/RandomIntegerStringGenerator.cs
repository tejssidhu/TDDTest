using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNumberString.Interfaces;

namespace RandomNumberString
{
    public class RandomIntegerStringGenerator : IRandomIntegerStringGenerator
    {
        private IRandomIntegerListGenerator _randomIntegerListGenerator;
        private int _minValue;
        private int _maxValue;

        public RandomIntegerStringGenerator(IRandomIntegerListGenerator randomIntegerListGenerator, int minValue, int maxValue)
        {
            _randomIntegerListGenerator = randomIntegerListGenerator;
            _minValue = minValue;
            _maxValue = maxValue;
        }

        public string getRandomIntegerString(int numberOfIntegers)
        {
            StringBuilder sb = new StringBuilder();

            List<int> myIntegerList = _randomIntegerListGenerator.getRandomIntegers(numberOfIntegers, _minValue, _maxValue);

            foreach (int item in myIntegerList)
            {
                sb.Append(item.ToString());
                
                if (item != myIntegerList.Last())
                    sb.Append(",");
            }
            
            return sb.ToString();
        }
        
    }


}
