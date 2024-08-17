using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_2._User_Defined
{
    public class TemperatureIsNull : Exception
    {
        public TemperatureIsNull(string? message) : base(message)
        {
            ExceptionTime = DateTime.Now;
        }

        public string AdditionalMessage { get; set; }
        public DateTime ExceptionTime { get; set; }
    }
}
