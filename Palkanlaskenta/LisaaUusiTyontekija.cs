using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta
{
	class LisaaUusiTyontekija : MenuToiminto
	{
		public override void Suorita()
		{
			Console.Clear();

			try
			{
				List<Tyontekija> tyontekijat = HaeTyontekijat();

				Console.WriteLine("Etunimi: ");
				string enimi = Console.ReadLine();

				Console.WriteLine("Sukunimi: ");
				string snimi = Console.ReadLine();

				Console.WriteLine("Tuntimäärä (per vko): ");
				int tunnit = int.Parse(Console.ReadLine());

				Console.WriteLine("Tuntipalkka (muodossa 0,00): ");
				double tuntipalkka = double.Parse(Console.ReadLine());

				List<Sivukulu> sivukulut = new();
				string input = "";
				while (input != "2")
				{
					Console.WriteLine("1. Lisää sivukulu\n2. Valmis");
					input = Console.ReadLine();

					if (input == "1")
					{
						Console.WriteLine("Sivukulun nimi: ");
						string kulunNimi = Console.ReadLine();

						Console.WriteLine("Sivukulun määrä (muodossa 0,00): ");
						double kulunMaara = double.Parse(Console.ReadLine());

						sivukulut.Add(new Sivukulu(kulunNimi, kulunMaara));
					}

				}

				Tyontekija uusi = new Tyontekija(enimi + " " + snimi, tunnit, tuntipalkka, sivukulut);

				tyontekijat.Add(uusi);
				Save.WriteToJsonFile("tyontekijat.json", tyontekijat);
			}
			catch (FormatException)
			{
				Console.WriteLine("Virheellinen Arvo.");
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
