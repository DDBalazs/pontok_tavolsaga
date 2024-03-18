using System;


namespace Pontok_távolsága
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérlek add meg az első (x) kordinátát: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Kérlek add meg a második (y) kordinátát: ");
            int y = int.Parse(Console.ReadLine());

            double tav = Math.Sqrt((x*1 - x*2) * (x*2 - x*1) * (y*1 - y*2) * (y*2 - y*1));

            Console.WriteLine($"A két pont közötti távolság: {tav}");
        }
    }
}