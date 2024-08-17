using Interface_2._Exercise.Interfaces;
using Interface_2._Exercise.Phones;
using System.Collections.Generic;

namespace Interface_2._Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an Interface Itelephone which contain 2 strings Name, Model, and NetworkGeneration (int)
            //make a phone class
            //create a method in program.cs for printing phones with network generation newer than 3G

            //add a second Interface IDisplay which will contain bool value of fingeprint detials
            //inherit IDisplay to at least one phone, and set its value on true 
            //Implement in method for showing phones, if they have a fingerprint sensor


            List<ITelephone> phones = new List<ITelephone>();
            phones.Add(new Samsung()
            {
                Name = typeof(Samsung).Name,
                Model = "Galaxy S2",
                NetworkGeneration = 2
            });
            phones.Add(new Iphone()
            {
                Name = typeof(Iphone).Name,
                Model = "11 Pro",
                NetworkGeneration = 4
            });
            phones.Add(new Xiaomi()
            {
                Name = typeof(Xiaomi).Name,
                Model = "Redmi Note 12",
                NetworkGeneration = 5
            });

            foreach (var phone in phones)
            {
                ShowNetwork(phone);
            }
        }
        static void ShowNetwork(ITelephone telephone)
        {
            if (telephone is IDisplay)
            {
                Console.WriteLine("Phone has a fingerprint sensor");

                if (((IDisplay)telephone).FingerPrint)
                {
                    Console.WriteLine("Phone can be unlocked using a fingerprint");
                }
            }
            if (telephone.NetworkGeneration > 3)
            {
                Console.WriteLine($"{telephone.Name} {telephone.Model} {telephone.NetworkGeneration}G");
            }
            else
            {
                Console.WriteLine($"{telephone.Name} {telephone.Model} Network Generation is older than 3G");
            }
            
        }
    }
}
