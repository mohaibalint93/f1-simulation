﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class Driver
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int DriverLevel { get; set; }

        public Driver(string name, int driverlevel)
        {
            Name = name;
            Points = 0;
            DriverLevel = driverlevel;
        }
    }
}
