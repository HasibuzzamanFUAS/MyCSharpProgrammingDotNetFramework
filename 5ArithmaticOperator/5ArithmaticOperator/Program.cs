using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ArithmaticOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 30;
            int secondNumber = 40;

            int result= firstNumber + secondNumber;
            float result2 = secondNumber / firstNumber;
            Console.WriteLine("The result:"+result);
            Console.WriteLine("The divide Result: " + result2);
            Console.ReadLine();
        }
    }
}
