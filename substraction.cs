using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class substraction
    {
        public int Sub()
        {
            //Console.WriteLine("First Value Should be greater than Second Value");
            Console.WriteLine("Enter the numbers");
            var x = Convert.ToInt32(Console.ReadLine());
            var y = Convert.ToInt32(Console.ReadLine());
            if(x>y)
            {
                return x - y;
            }
            else
            {
                return y - x;
            }
        }
    }
}
