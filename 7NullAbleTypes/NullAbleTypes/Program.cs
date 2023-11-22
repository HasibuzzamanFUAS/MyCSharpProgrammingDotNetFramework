using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullAbleTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? firstNumber = 255;
            int secondNumber;

            //if (firstNumber != null)
            //{
            //    secondNumber = 400;
            //}
            //else
            //{
            //    secondNumber = (int)firstNumber;
            //}
            //Console.WriteLine(secondNumber);
            //Console.ReadLine();
            // we can write the below code instead of prev if/else condition code
            //by using the nullable type "??" - see below

            secondNumber = firstNumber ?? 0;
            Console.WriteLine(secondNumber);
            Console.ReadLine();
        }
    }
}
