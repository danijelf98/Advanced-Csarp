using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2._Exercise.Interfaces
{
    public interface ITelephone
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int NetworkGeneration { get; set; }
    }
}
