using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_2._Exercise.Interfaces;

namespace Interface_2._Exercise.Phones
{
    public class Xiaomi : ITelephone, IDisplay
    {
        public Xiaomi()
        {
            this.FingerPrint = true;
        }

        public string Name { get; set; }
        public string Model { get; set; }
        public int NetworkGeneration { get; set; }
        public bool FingerPrint { get; set; }
    }
}
