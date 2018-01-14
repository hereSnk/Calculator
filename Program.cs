using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Addition add = new Addition();
            substraction sub = new substraction();
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("\n 1 - For Addition \n 2 - For Substraction \n 3 - For Multiplication \n 4 - For Division");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
               int c = add.Add();
               Console.WriteLine("The Sum Value is {0}", c);
            }
            if (a == 2)
            {
                int c = sub.Sub();
                Console.WriteLine("The Difference is {0}", c);
            }

            Console.ReadKey();

        }
    }
}
