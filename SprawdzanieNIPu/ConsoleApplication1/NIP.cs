//-----------------------------------------------------------------------
// <copyright file="NIP.cs" company="CompanyName">
// Company copyright tag.
// </copyright>
//----------------------------------------------------------------------- 

namespace ConsoleApplication1
 {
    using System;

    /// <summary>
    /// Klasa służy do sprawdzenia, czy wprowadzony ciąg znaków jest poprawnym numerem NIP i jego sformatowania.
    /// </summary>
 internal class NIP
 {

   public Int64 numer;

   public string Sformatuj;

   private int[] wagi = new int[] { 6, 5, 7, 2, 3, 4, 5, 6, 7 };

   private int Kontrolna;

   private bool CzyPoprawny;

   static int NtaCyfra(Int64 number, int digit)
   {
            return (int)((number / (int)Math.Pow(10, digit-1)) % 10);
   }

    /// <summary>
    /// Initializes a new instance of the NIP class.
    /// </summary>
    /// <param name="nr">Wprowadzony ciąg znaków</param>
   public NIP(string nr)
   {
      Int64 result;
      if (TryParse(nr, out result))
            {
                this.numer = result;
                this.Sformatuj = string.Format("{0:000-000-00-00}", this.numer);
                this.Kontrolna = ObliczKontrolna(this.numer);
                this.CzyPoprawny = this.DlugoscOK &&
                    (this.Kontrolna == (int)NtaCyfra(this.numer, 1));
            }
      else
      {
         this.Sformatuj = nr;
      }
   }

   public static bool TryParse(string nr, out Int64 result)
   {
            Int64 x;
            if (Int64.TryParse (nr.Trim (), out x)) 
            {
                result = x;
                return true;
            } 
            else 
            {
                result = 0;
                return false;
            }
   }
   
    /// <summary>
    /// Gets a value indicating whether długość jest poprawna
    /// </summary>
   private bool DlugoscOK
   {
    get
    {
        return this.numer.ToString().Length == 10;
    }
   }
   
    /// <summary>
    /// Gets - sumę kontrolną
    /// </summary>

   private int ObliczKontrolna (Int64 numer)
   {

     int x = 0;
     int liczba = 0;

     for (int i = 0; i < wagi.Length; i++) 
     {
                    x = NtaCyfra(numer,10-i);
                    liczba = liczba + (x * wagi[i]);
     }

     liczba = liczba % 11;
     return (int)liczba;

    }

    /// <summary>
    /// Gets a STRING indicating whether numer NIP jest poprawny?
    /// </summary>
    public string CzyPoprawnyTekst
    {
        get
        {
                return this.CzyPoprawny ? "jest prawidłowy" : "jest niepoprawny";
        }
    }
   }
  }
