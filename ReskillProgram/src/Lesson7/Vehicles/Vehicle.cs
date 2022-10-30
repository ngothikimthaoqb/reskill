﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson5.Vehicles
{
    public abstract class Vehicle
    {
        public Chassis? Chassis { get; set; }
        public Transmission? Transmission { get; set; }
        public Engine? Engine { get; set; }

    }
}
