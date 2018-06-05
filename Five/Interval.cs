using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five
{
    public class Interval
    {
        //public int time;
        /*  
            we never reveal implementation detail
            Abstraction means showing whats necessary .. it is a thoughtProcess
            Encapsulation means hiding the complexity .. 
            encapsulation implements abstraction.
        */
        private int hour;
        private int min;

        public int GetTime()
        {
            var time = (hour * 60) + min;
            return time;
        }

        public void SetTime(int time)
        {
            hour = time / 60;
            min = time % 60;
        }
        //public int GetHour()
        //{
        //    return this.hour;
        //}

        //public int GetMin()
        //{
        //    return this.min;
        //}

        //public void SetHout(int hour)
        //{
        //    this.hour = hour;
        //}

        //public void SetMin(int min)
        //{
        //    this.min = min;
        //}
    }
}
