using System;

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
        public static int? Sum(int[] xs)
        {
            //Null, empty array control
            if (xs == null || xs.Length == 0)
            {
                return null;
            }


            int sum = 0;

            foreach (var item in xs)
            {
                sum += item;
            }

            return sum;
        }
    }
}
