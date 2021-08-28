using System;
using System.Threading.Tasks;
using ServiceReference1;

namespace NETCoreConsumer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new CalculatorServiceClient();

            var val1 = 11.8;
            var val2 = 14.7;
            Console.WriteLine($"val1: {val1}, val2: {val2}");
            var addResult = await client.AddAsync(val1, val2);
            Console.WriteLine($"Result from add: {addResult}");
            var subtractResult = await client.SubtractAsync(val1, val2);
            Console.WriteLine($"Result from subtract: {subtractResult}");

            Console.WriteLine("Press <Enter> to stop the client.");
            Console.ReadLine();

        }
    }
}
