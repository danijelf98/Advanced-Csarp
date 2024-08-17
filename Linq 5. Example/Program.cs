using Linq_5._Example.Model;

namespace Linq_5._Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>()
            {
                new Client { FullName = "Matt Nathan", Saldo = 123587.99, Bank = "ZABA" },
                new Client { FullName = "Kevin Levis", Saldo = 3000000.59, Bank = "RBA" },
                new Client { FullName = "Louis Bown", Saldo = 19000000, Bank = "PBZ" },
                new Client { FullName = "George Harrison", Saldo = 789542.33, Bank = "Erste" },
                new Client { FullName = "Gordan Belic", Saldo = 2000000, Bank = "PBZ" }
            };

            //grouping with lambda function/linq method syntax

            var groupedByBank = clients
                .Where(c => c.Saldo > 1000000)
                .GroupBy(
                c => c.Bank,
                c => c.FullName,
                (bank, millionaires) => new GroupedMillionaires()
                {
                    Bank = bank,
                    Millionaires = millionaires
                }).ToList();

            foreach (var millionaires in groupedByBank)
            {
                Console.WriteLine($"{millionaires.Bank}: {string.Join(" & ", millionaires.Millionaires)}");
            }

            //grouping by linq
            var bankGrouping = from client in clients
                               where client.Saldo >= 1000000
                               group client.FullName by client.Bank into bankGroup
                               select new GroupedMillionaires
                               {
                                   Bank = bankGroup.Key,
                                   Millionaires = bankGroup.ToList()
                               };

            Console.WriteLine();
            foreach (var client in bankGrouping)
            {
                Console.WriteLine($"{client.Bank}: {string.Join(" & ", client.Millionaires)}");
            }
        }
    }
}
