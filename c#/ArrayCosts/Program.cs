using System;

namespace ArrayCosts
{
    class Program
    {
        private static int[] _costs;

        private static void init()
        {
            _costs = new int[5] { 10, 15, 20, 25, 30 };
        }

        private static void reset()
        {
            _costs[0] = 0;
            _costs[1] = 0;
            _costs[2] = 0;
            _costs[3] = 0;
            _costs[4] = 0;
        }

        private static void changeValues(ref int[] values)
        {
            values[0] = 10 * values[0];
            values[1] = 10 * values[1];
            values[2] = 10 * values[2];
            values[3] = 10 * values[3];
            values[4] = 10 * values[4];
        }

        static void Main(string[] args)
        {
            init();
            foreach (int value in _costs)
            {
                Console.WriteLine($"value = {value}");
            }
            Console.WriteLine("Changing values");
            changeValues(ref _costs);
            foreach (int value in _costs)
            {
                Console.WriteLine($"value = {value}");
            }
        }
    }
}
