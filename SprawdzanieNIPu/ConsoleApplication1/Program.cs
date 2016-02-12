using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            NIP przyklad = new NIP("1744751686");
            string jaka = przyklad.czyPoprawna ? "jest prawidłowy": "jest niepoprawny";

            Console.Write(string.Format("Numer NIP: {0} {1}", przyklad.podziel, jaka));
			
			NIP inny = new NIP("1744751684");
            jaka = inny.czyPoprawna ? "jest prawidłowy": "jest niepoprawny";

            Console.Write(string.Format("Numer NIP: {0} {1}", inny.podziel, jaka));

            var name = Console.ReadLine();
        }
    }
}
