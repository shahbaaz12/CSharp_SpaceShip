using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two
{
    class TypeConversions
    {
        static void Main(string[] args)
        {
            const float Pie = 3.14f;
            int integer = 5;
            byte bytes = Byte.MaxValue;
            integer = int.MaxValue;
            //implicit type conversion
            integer = bytes;

            /*explicit type conversion
            implicit not allowed due to data loss
            here bytes =                0001;
            integer    = 0000 0000 0000 0001;
            bytes = (byte)integer;



            //converting string in this way is not possible

            string st = "123";

            //integer = (int)st;

            // There are two ways to do so
            integer = Convert.ToInt32(st);

            bytes = byte.Parse(st);


            /*  int.Parse(string s)
Integer in RANGE > returns integer value
Null value > ArguementNullException
Not in format > FormatException
Value not in RANGE > OverflowException
Convert.ToInt32(string s)
Integer in RANGE > returns integer value
Null value > returns "0"
Not in format > FormatException
Value not in RANGE > OverflowException

 
             The difference is this:

Int32.Parse() and Int32.TryParse() can only convert strings. Convert.ToInt32() can take any class that implements IConvertible. If you pass it a string, then they are equivalent, except that you get extra overhead for type comparisons, etc. If you are converting strings, then TryParse() is probably the better option.
             */
            
            checked
            {
                //stopping overflow hardly used
                //x += 1;

            }
           

            Console.WriteLine("{0}", integer);
            Console.ReadKey();
            

        }
        

    }
}
