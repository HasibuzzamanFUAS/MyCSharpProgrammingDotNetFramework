using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte number = 255; //declared a variable called "number" which is 255
            Console.WriteLine("First Byte variable: "+number); //print the assigned variable number
            number = 250; //here we assign again another variable and the previous value is cleaned by default.
            Console.WriteLine("Latest byte Variable: "+number);  //here print the latest assign variable

            int v1 = number + 1;
            Console.WriteLine("Integer type variable: "+v1);  //here print the sum  

            short v2 = (short)(number + 5);
            Console.WriteLine("Short type variable: " + v2);  //here print the short variable

            long v3 = (long)(number + 100);
            Console.WriteLine("Long type variable: " + v3);  //here print the long variable

            float v4 = (float)(number / 11.7); //or it can be = 3.1416f; should add f at the end. 
            Console.WriteLine("Float type variable: " + v4); //here print the float variable

            double v5 = number + 100000.67665;    //double can be floating number as well
            Console.WriteLine("Double type Variable: "+v5); //here print the double variable

            decimal v6 = number + 100000000;
            Console.WriteLine("Decimal type variable: " + v6);

            char v7 = 'H'; //char always write in between single qoutation
            Console.WriteLine("Character type variable: " + v7);   //print character

            string v8 = "Hasibuzzaman";   //string always write in between double qoutation
            Console.WriteLine("String type variable: " + v8); //print tring

            number = (byte) (number + 6); // the result will be 0 caused by system overflow (byte-range max 255)
            Console.WriteLine("Overflow result for Byte type variable: "+number);  //here print the latest assign variable

           

<<<<<<< HEAD
            //important: v1, v2 ... v8 all are idetifier which can not start with a number neigther a white space(eg. "1v" or "va name")
            // can't use the reserve keyword, if you want to use then add the sign @ (eg. @string)
=======
            //important: v1, v2 ... v8 all are identifiers which can not start with a number neither a white space(eg. "1v" or "va name")
            // can't use the reserved keyword, if you want to use then add the sign @ (eg. @string)
>>>>>>> bd30c07cfe5091772caeaf6cc88c7383351892d2
            

            Console.ReadLine();
        }
    }
}
