using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_7._Exercise
{
    public class PriceIsNullOrZero : Exception
    {
        public PriceIsNullOrZero(string? message) : base(message)
        {
        }
    }
    public class ThereIsNoItemInProducts : Exception
    {
        public ThereIsNoItemInProducts(string? message) : base(message)
        {
        }
    }
    public class DescriptionIsTooLong : Exception
    {
        public int NumOfChars { get; set; }
        public DescriptionIsTooLong(int numOfChars) : base($"Max number of chars is 50, and you have {numOfChars}")
        {
            this.NumOfChars = numOfChars;
        }
    }
    
}
