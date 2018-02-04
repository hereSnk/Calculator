using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Addition
    {
        public int Add()
        {
            Console.WriteLine("Enter the numbers");
            var c = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            return b + c;
        }
    }
}
