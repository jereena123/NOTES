using System;

namespace TemperatureMonitoring
{
    // 1. Define a delegate for temperature change events
    public delegate int TemperatureChangeDelegate(int temperature);

    class Program
    {
        // Define the event based on the delegate
        public event TemperatureChangeDelegate TemperatureChangeEvent;

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.TemperatureChangeEvent = obj.GetTemperature;
            Random random = new Random();
            int temperature = random.Next(-100, +150);
            obj.TemperatureChangeEvent(temperature);

            Console.WriteLine("Temperature is" + temperature);

            Console.ReadKey();

        }

        public int GetTemperature(int temperature)
        {
            if (temperature <= 0)
            {
                Console.WriteLine("critical temperarture reached");
            }
            else if (temperature >= 100)
            {
                Console.WriteLine("critical temperature reached");
            }
            else
            {
                Console.WriteLine("normal temperature");
            }
            return temperature;
        }

    }
}
