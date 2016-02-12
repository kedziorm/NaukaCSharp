using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            NIP mk = new NIP("5342348938");
            string jaka = mk.czyPoprawna ? "jest prawidłowy": "jest niepoprawny";

            Console.Write(string.Format("Numer NIP: {0} {1}", mk.podziel, jaka));

            var name = Console.ReadLine();
        }
    }
}
