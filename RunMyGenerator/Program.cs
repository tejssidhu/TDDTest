using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNumberString;

namespace RunMyGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RandomIntegerStringGenerator randomIntegerStringGenerator = new RandomIntegerStringGenerator(new RandomIntegerListGenerator(), 1, 100);

            string myRandomIntegerString = randomIntegerStringGenerator.getRandomIntegerString(5);

            Console.Write(myRandomIntegerString);
            Console.ReadLine();
        }
    }
}
