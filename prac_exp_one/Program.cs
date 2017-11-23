using System;
using static System.Console;

namespace prac_exp_one
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            int userAge = 0;
            int currentYear = 0;

            Write("Please enter your name: ");
            userName = ReadLine();
            Write("Please enter your age: ");
            userAge = Convert.ToInt32(ReadLine());
            Write("Please enter the current year: ");
            currentYear = Convert.ToInt32(ReadLine());
            WriteLine("Hello there! My name is {0} and I am {1} years old. " +
                      "I was born in {2}.", userName, userAge, currentYear - userAge);

        }
    }
}
