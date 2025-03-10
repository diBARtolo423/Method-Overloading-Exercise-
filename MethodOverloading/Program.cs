﻿namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
            {
            return num1 + num2;
            }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;

            if (sum == 1)
            {
                return sum + " " + "dollar";
            }
            else if (sum > 1)
            {
                return sum + " " + "dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        


        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 5));
            var answer = Add(4.53m, 3.10m);
            Console.WriteLine(answer);
            var answer2 = Add(1, 0, true);
            Console.WriteLine(answer2);
        }
    }
}
