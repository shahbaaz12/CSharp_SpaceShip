using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four
{
    class ValAndRefTypes
    {
        static void Main(string[] args)
        {
            //value types
            int a = 5;
            int b = 10;
            b = a;
            b++;
            Console.WriteLine("Value of a is {0}\nValue of b is {1}",a,b);
            //reference types

            Cart mangoBox = new Cart();
            Cart mangoBox2 = new Cart();
            mangoBox.AddToCart(12);
            mangoBox2.AddToCart(10);
            Console.WriteLine("Mangoes in Box1 are : {0}\nMangoes in Box2 are : {1}",mangoBox.Quantity,mangoBox2.Quantity);


            mangoBox2 = mangoBox;

            mangoBox2.AddToCart(25);


            Console.WriteLine("Mangoes in Box1 are : {0}\nMangoes in Box2 are : {1}", mangoBox.Quantity, mangoBox2.Quantity);
            Console.ReadKey();
        }
    }
}
