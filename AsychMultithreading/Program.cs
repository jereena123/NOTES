using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsychMultithreading
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("main started");
            //start two tasks concurrently
            Task<int> resultsum = CalculateSumAsync(10, 5);
            Task<double> resultdivision = CalculateDivisionAsync(10, 7);
            //await the completion of both tasks
            int sum = await resultsum;
            double division = await resultdivision;

            //print
            Console.WriteLine($"Sum:{ sum}");
            Console.WriteLine($"Division:{division}");
            Console.WriteLine("main finished");
            Console.ReadKey();
        }
        //METHOD1-SUM
        static async Task<int> CalculateSumAsync(int first,int second)
        {
            await Task.Delay(1000);
            return first+second;
        }
        static async Task<double> CalculateDivisionAsync(int first, int second)
        {
            await Task.Delay(1000);
            return (double)first/second;
        }
    }
}
