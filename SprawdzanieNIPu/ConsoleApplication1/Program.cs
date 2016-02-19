namespace ConsoleApplication1
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            NIP[] numeryDoTestow = new NIP[7] 
            { 
                new NIP("7265163641"), new NIP("To będzie błąd"), new NIP("7265163642"),
                new NIP("1111222333334456"), new NIP("2551050638"),
                    new NIP("  "), new NIP("234 coś tu będzie źle") 
            };
            string jaka;

            for (int i = 0; i <= numeryDoTestow.Length - 1; i++) 
            {
                jaka = numeryDoTestow[i].CzyPoprawny ? "jest prawidłowy" : "jest niepoprawny";
                Console.WriteLine(string.Format("Numer NIP: '{0}' {1}", numeryDoTestow[i].Sformatowana, jaka));
            }
           
            Console.ReadLine();
        }
    }
}
