//-----------------------------------------------------------------------
// <copyright file="NIP.cs" company="CompanyName">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------- 

namespace ConsoleApplication1
 {
    using System;

    /// <summary>
    /// Klasa służy do sprawdzenia, czy wprowadzony ciąg znaków jest poprawnym numerem NIP.
    /// </summary>
 internal class NIP
 {
    /// <summary>
    /// Wprowadzony numer po usunięciu białych znaków
    /// </summary>
   private string numer;

    /// <summary>
    /// Initializes a new instance of the NIP class.
    /// </summary>
    /// <param name="nr">Wprowadzony ciąg znaków</param>
   public NIP(string nr)
   {
    this.numer = nr.Trim();
   }
   
    /// <summary>
    /// Gets a value indicating whether długość jest poprawna
    /// </summary>
   public bool DlugoscOK
   {
    get
    {
     return this.numer.Length == 10;
    }
   }
   
    /// <summary>
    /// Gets - sumę kontrolną
    /// </summary>
   public int Kontrolna
   {
    get
    {
     int[] wagi = new int[] { 6, 5, 7, 2, 3, 4, 5, 6, 7 };
     double x = 0;
     double liczba = 0;

     for (int i = 0; i < wagi.Length; i++) 
     {
      x = Convert.ToDouble(this.numer.Substring(i, 1));
                    liczba = liczba + (x * wagi[i]);
     }

     liczba = liczba % 11;

     return (int)liczba;
    }
   }

    /// <summary>
    /// Gets a value indicating whether numer NIP jest poprawny?
    /// Idotyczne jest ścisłe stosowanie się do zasad StyleCopa, skoro piszę komentarzae po polsku
    /// </summary>
   public bool CzyPoprawna
   {
    get
    {
       return this.DlugoscOK && 
        (this.Kontrolna == Convert.ToDouble(this.numer.Substring(9, 1)));
    }
   }

    /// <summary>
    /// Gets a STRING indicating whether numer NIP jest poprawny?
    /// </summary>
    public string CzyPoprTekst
    {
        get
        {
                return this.CzyPoprawna ? "jest prawidłowy" : "jest niepoprawny";
        }
    }

   /// <summary>
   /// Gets - zwraca ładnie sformatowany numer NIP.
   /// </summary>
   public string Podziel
   {
    get
    {
     if (this.DlugoscOK)
     {
      return string.Format(
       "{0}-{1}-{2}-{3}",
       this.numer.Substring(0, 3),
       this.numer.Substring(3, 3),
       this.numer.Substring(6, 2),
       this.numer.Substring(8, 2));
     }
     else
     {
      return this.numer;
     }
    }
   }
  }
 }
