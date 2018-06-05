using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One
{
    class ValueTypes
    {
        
        static void Main(string[] args)
        {



            const double Pie = 3.1416;

            int x, y, z;
            float nos = 1.5f;
            x = y = 5;
            z = x + y;
            x++;
            ++x;
            char a = 'a';
            string b = "Hi";
            string B = "Welcome";
            Console.WriteLine("{0} + {1} = {2}", x, y, z);
           
            //Scope of a variable
            //{
            //   int  a = 4;
            //    {
            //       int b = 3;

            //        {
            //            int c = 7;
            //            Console.WriteLine("{0}", c);
            //        }
            //        Console.WriteLine("{0}", c);
            //    }
            //    Console.WriteLine("{0}", a);

            //}
            Console.ReadKey();

        }
    }
}
