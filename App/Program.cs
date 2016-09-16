using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool CheckAge(Person p)
        {
            throw new NotImplementedException();
        }

        public static int[] DoubleAll(int[] xs)
        {
            throw new NotImplementedException();
        }

        public static string FizzBuzz(int x)
        {
            if (x % 3 == 0 && x % 5 == 0)
                return "FizzBuzz";
            if (x % 3 == 0)
                return "Fizz";
            if (x % 5 == 0)
                return "Buzz";
            else
                return x.ToString();
        }
        public static int Sum(int[] xs)
        {
            throw new NotImplementedException();
        }
    }
}
