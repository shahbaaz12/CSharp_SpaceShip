using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four
{
    public class Cart
    {
        public int Quantity;


        public void AddToCart(int qty)
        {
            this.Quantity = qty;
        }
    }
}
