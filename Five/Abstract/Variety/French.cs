using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Abstract.Variety
{
    public class French : Humans
    {
        public override void Speak()
        {
            Console.WriteLine("Bonjour");
        }
    }
}
