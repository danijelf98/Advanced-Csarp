﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_2._Exercise.Interfaces;

namespace Interface_2._Exercise.Phones
{
    public class Samsung : ITelephone
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int NetworkGeneration { get; set; }
    }

}
