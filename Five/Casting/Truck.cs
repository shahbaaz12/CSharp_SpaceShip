using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Casting
{
    public class Truck : Vehicle
    {
        public bool IsLoaded { get; set; }
        public int NoOfTyres { get; set; }

        public void LoadUnload()
        {
            if (IsLoaded)
            {
                Console.WriteLine("Unloading the truck Reg No : {0}",RegNos);
                IsLoaded = false;
            }
            else
            {
                Console.WriteLine("Loading the truck Reg No : {0}", RegNos);
                IsLoaded = true;
            }
        }
    }
}
