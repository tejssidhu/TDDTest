using System;
using RandomNumberString;

namespace RunMyGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RandomIntegerStringGenerator randomIntegerStringGenerator = new RandomIntegerStringGenerator(new RandomIntegerListGenerator(), 1, 100);

            string myRandomIntegerString = randomIntegerStringGenerator.GetRandomIntegerString(5);

            Console.Write(myRandomIntegerString);
            Console.ReadLine();
        }
    }
}
