using System;

namespace Z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clothes clothes = new Clothes("Kolorowe Oversized");

            Hat hat = new Hat("Rodeo hat");

            BusDriver bus = new BusDriver();

            bus.Show();

            bus.WearHat(hat);

            bus.WearClothes(clothes);

            bus.Show();

            bus = null;

            Console.WriteLine(clothes);

            Console.WriteLine(hat);
        }
    }
}
