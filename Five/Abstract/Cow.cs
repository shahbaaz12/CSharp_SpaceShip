﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five.Abstract
{
    public class Cow : LivingBeing
    {
        public override void Speak()
        {
            Console.WriteLine("Mooo");
        }
    }
}
