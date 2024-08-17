using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_2._User_Defined
{
    public class Temperature
    {
        public int temp { get; set; }

        public void ShowTemperatuer()
        {
            if (temp == 0)
            {
                throw new TemperatureIsNull("Temperature is 0");
            }
            else
            {
                Console.WriteLine($"Temperature is {temp}");
            }
        }
    }
}
