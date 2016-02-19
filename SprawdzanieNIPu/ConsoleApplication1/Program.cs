//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CompanyName">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------- 
namespace ConsoleApplication1
{
    using System;

    /// <summary>
    /// Domyślna klasa programu konsolowego tworzona przez Monodevelop
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Domyślna metoda Main
        /// </summary>
        private static void Main()
        {
            NIP[] numeryDoTestow = new NIP[5] 
            { 
                new NIP("7265163641"), new NIP("To będzie błąd"), new NIP("7265163642"),
                new NIP("1111222333334456"), new NIP("2551050638") 
            };

            for (int i = 0; i <= numeryDoTestow.Length - 1; i++) 
            {
                Console.WriteLine(string.Format("Numer NIP: '{0}' {1}", numeryDoTestow[i].Sformatuj, numeryDoTestow[i].CzyPoprawnyTekst));
            }
           
            Console.ReadLine();
        }
    }
}
