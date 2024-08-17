using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_5._Example.Model
{
    public class GroupedMillionaires
    {
        public string Bank { get; set; }
        public IEnumerable<string> Millionaires { get; set; }
    }
}
