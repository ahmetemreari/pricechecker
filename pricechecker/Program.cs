using System;

namespace PriceChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hangi meyveyi almak istersiniz? Elma/Armut/Muz/Cilek/Diger: ");
            string meyveler = Console.ReadLine().ToLower();

            // Elma
            if (meyveler == "elma")
            {
                Console.WriteLine("Elma = 2 TL");
            }
            // Armut
            else if (meyveler == "armut")
            {
                Console.WriteLine("Armut = 3 TL");
            }
            // Muz
            else if (meyveler == "muz")
            {
                Console.WriteLine("Muz = 3 TL");
            }
            // Çilek
            else if (meyveler == "çilek")
            {
                Console.WriteLine("Çilek = 2 TL");
            }
            // Diğer meyveler
            else
            {
                Console.WriteLine("Diğer bütün meyveler = 4 TL");
            }
        }
    }
}
