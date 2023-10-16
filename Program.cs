using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_two_numbers_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int temp;

            a = -13;
            b = 2;


            temp = a;
            a = b;
            b=temp;

          Console.WriteLine("\n After swapping:" );
          Console.WriteLine("\n a= "+ a);
            Console.WriteLine("\n b= "+ b);

            Console.Read();
        }
    }
}
