	using System;

	namespace ConsoleApplication1
	{
		class NIP
		{
			public string numer;

			public NIP(string nr)
			{
				this.numer = nr.Trim();
			}

			public Boolean dlugoscOK
			{
				get
				{
					return this.numer.Length == 10;
				}
			}

			public int kontrolna
			{
				// zwraca sumę kontrolną
				get
				{
					int[] wagi = new int[] {6, 5, 7, 2, 3, 4, 5, 6, 7};
					double x=0;
					double liczba=0;

					for (int i = 0; i < wagi.Length; i++) 
					{
						x = Convert.ToDouble(numer.Substring(i, 1));
						liczba = liczba + x*wagi[i];
					}

					liczba = liczba % 11;

					return (int)liczba;
				}
			}

			public Boolean czyPoprawna
			{
				get
				{
				   return this.dlugoscOK && 
					   (this.kontrolna == Convert.ToDouble(this.numer.Substring(9, 1)));
				}
			}

			public string podziel
			{
				// zwraca ładnie sformatowany numer NIP
				get
				{
					if (this.dlugoscOK)
					{
						return string.Format("{0}-{1}-{2}-{3}",
							this.numer.Substring(0, 3),
							this.numer.Substring(3, 3),
							this.numer.Substring(6, 2),
							this.numer.Substring(8, 2));
					}
					else
					{
						return this.numer;
					};
				}
			}
		}
	}
