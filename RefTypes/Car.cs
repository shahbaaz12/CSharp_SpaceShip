using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three
{
    public class Car
    {
        public string Brand;
        public int Price;

        public void Drive()
        {
            Console.WriteLine("Driving {0}",this.Brand);
        }
    }
}
