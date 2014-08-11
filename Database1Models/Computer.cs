﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database1Models.Mapping
{
    public class Computer
    {
        public virtual int Id { get; set; }

        public virtual string Brand { get; set; }
        public virtual string Model { get; set; }
        public virtual User Owner { get; set; }
    }
}
