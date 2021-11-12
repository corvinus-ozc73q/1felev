﻿using System;
using nyolcadikhet.Abstractions
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyolcadikhet.Entities
{
     public class BallFactory : ToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }
    }
}

