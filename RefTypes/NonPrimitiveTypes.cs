using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three
{
    class NonPrimitiveTypes
    {
        

        static void Main(string[] args)
        {
            //strings

            string firstName = "Walter";
            string lastName = "White";
            //string name = firstName +" "+ lastName;
            string name = string.Format("{0}  {1}", firstName, lastName);

            int[] num = new int[] { 1, 2, 3, 4 }; ;
            string numList = string.Join(",", num);

            char x = firstName[2];

            //Note Strings are Immutable
            //firstName[2] = 'p' => not allowed

            //Verbatim String
            string path = "c:\\User\\Shahbaaz\\Desktop";
            //string path = @"c:\User\Shahbaaz\Desktop";



            //arrays

            int[] ar = new int[] { 1, 2, 3, 4 };

            foreach (var item in ar)
            {
                Console.WriteLine("{0}", item);

            }
            Console.WriteLine("Array Length : {0}", ar.Count());

            //classes
            Car Polo = new Car();
            Polo.Brand = "Volkswagen";
            Polo.Price = 50;

            Car Carrera = new Car();
            Carrera.Brand = "Porsche";
            Carrera.Price = 100;

            Polo.Drive();
            Carrera.Drive();

            
            //structs
            Books book1;
            book1.Pages = 112;
            book1.Title = "Harry Potter";

            Console.WriteLine("The Book is :{0}\nBased on {1} pages", book1.Title, book1.Pages);

            //enum eg

            var mail = Shipping.Regular;
            Console.WriteLine((int)mail);
            Console.WriteLine(mail.ToString());
            var type = 2;
            Console.WriteLine((Shipping)type);

            Console.WriteLine("{0}",numList);



           
            Console.ReadKey();



        }
       

        //Enums No of related constants
        // by def enum are int
        public enum Shipping : byte
        {
            Regular = 1,
            Express = 2

                // if we donot assign val by default values will be 1,2,3...
        }

        
    }
}
