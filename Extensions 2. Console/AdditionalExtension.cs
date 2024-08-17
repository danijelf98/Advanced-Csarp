using Extensions_2._Console.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions_2._Console
{
    public static class AdditionalExtension
    {
        public static void AdditionalExtensionMethod(this BasicClass basicClassObject)
        {
            Console.WriteLine("I'm extended method for class BasicClass");
        }
    }
}
