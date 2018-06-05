using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Abstract
{
    /*
     1.Abstract methods do not contain implementation
     2.Abstract methods can reside only in abstract class
     3.Abstract class cannot be instantiated.
     4.All Abstract methods needs to be implemented in the derrived class


        Abstract forces other developer to follow your design 
        and provide a common behaviour, i.e. here any developer 
        derriving from livingBeings is forced to implement speak
     */
    public abstract class LivingBeing
    {
        public abstract void Speak();
    }
}
