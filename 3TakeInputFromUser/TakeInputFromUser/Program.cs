using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeInputFromUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your name: "); //to print 
            Console.WriteLine(Console.ReadLine());  //to input & output
            Console.WriteLine("Please Enter Your Age: ");
            Console.WriteLine(Console.ReadLine());
            Console.ReadLine();  //to read
        }
    }
}
