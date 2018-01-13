using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Addition add = new Addition();
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1 - For Addition \n 2 - For Substraction \n 3 - For Multiplication \n 4 - For Division");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
               int c = add.Add();
               Console.WriteLine("The Sum Value is {0}", c);
            }

            Console.ReadKey();

        }
    }
}
