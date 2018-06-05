using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five
{
    public class Order
    {
        public int OrderId;
        public string OrderDetail;

        //Use constructors when you need to initialize certain fields.
        //eg: lists etc
        public Order()
        {

        }
        public Order(int id)
        {
            OrderId = id;
        }

        /*notice we are trying to initialize id which we have 
        already initialized in the ctor above.(allowed)
        Thus breaking SRP...
        better solution would be to use this keyword
        public Order(int id, string detail)
        {
            OrderId = id;
            OrderDetail = detail;
        }
        */


        public Order(int id, string detail)
            : this(id) //calling single param ctor first
        {
            OrderDetail = detail;
        }
        /*
          using "this" complicates the flow so keep use to minimum

         */
    }
}
