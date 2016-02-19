namespace ConsoleApplication1
 {
    using System;

    /// <summary>
    /// Klasa służy do sprawdzenia, czy wprowadzony ciąg znaków jest poprawnym numerem NIP i jego sformatowania.
    /// </summary>
 internal class NIP
 {
   private long numer;
   private int[] wagi = new int[] { 6, 5, 7, 2, 3, 4, 5, 6, 7 };
   private int kontrolna;

   private bool czyPoprawny;
   private string sformatowana;

   public bool CzyPoprawny
   {
     get 
     {
        return this.czyPoprawny;
     }
    }

    public string Sformatowana
    {
      get 
       {
         return this.sformatowana;
        }
     }
            
   public NIP(string nr)
   {
      nr = nr.Trim();
            long x;
            if (nr.Length == 10 && long.TryParse(nr.Trim(), out x))
            {
                this.numer = x;
                this.sformatowana = string.Format("{0:000-000-00-00}", this.numer);
                this.kontrolna = this.ObliczKontrolna(this.numer);
                this.czyPoprawny = this.kontrolna == (int)NtaCyfra(this.numer, 9);
            }
      else
      {
         this.sformatowana = nr;
         this.czyPoprawny = false;
      }
   }

   public static int NtaCyfra(long number, int digit)
   {
            return int.Parse(number.ToString().Substring(digit, 1));
   }
            
   private int ObliczKontrolna(long numer)
   {
     int x = 0;
     int liczba = 0;

     for (int i = 0; i < this.wagi.Length; i++) 
     {
        x = NtaCyfra(numer, i);
        liczba = liczba + (x * this.wagi[i]);
     }

     liczba = liczba % 11;
     return (int)liczba;
    }
   }
  }
