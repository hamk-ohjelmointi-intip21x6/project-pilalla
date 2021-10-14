using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Palkanlaskenta
{
	[JsonObject]
	class Tyontekija
	{
		public string Nimi { get; set; }
		public int Tunnit { get; set; }
		public double Tuntipalkka { get; set; }
		public List<Sivukulu> Sivukulut { get; set; }

		//constructor
		public Tyontekija(string nimi, int tunnit, double tuntipalkka, List<Sivukulu> sivukulut) {
			Nimi = nimi;
			Tunnit = tunnit;
			Tuntipalkka = tuntipalkka;
			Sivukulut = sivukulut;
		}

		public void ListaaTiedot()
		{
			double bruttoPalkka = Tunnit * Tuntipalkka * 4; //oletetaan että palkka maksetaan kuukausittain, ja että kuukausi on aina 4 viikkoa.
			double nettoPalkka = LaskePalkka(bruttoPalkka);
			Console.WriteLine($"{Nimi} | Tunnit viikossa: {Tunnit} | Tuntipalkka: {Tuntipalkka:F} e | Bruttopalkka (kk): {bruttoPalkka:F} e | Nettopalkka: {nettoPalkka:F} e");
		}

		public double LaskePalkka(double brutto)
		{
			double nettoPalkka = brutto;
			if (Sivukulut != null && Sivukulut.Count > 0)
			{
				foreach (var kulu in Sivukulut)
				{
					nettoPalkka -= kulu.Maara;
				}
			}
			
			return nettoPalkka;
		}

		public void TulostaPalkkaTiedot()
		{
			ListaaTiedot();
			Console.WriteLine("\nSivukulut: ");

			if (Sivukulut != null && Sivukulut.Count > 0)
			{
				double yhteensa = 0;
				foreach (var kulu in Sivukulut)
				{
					Console.WriteLine($"{kulu.Nimi} -{kulu.Maara} e");
					yhteensa += kulu.Maara;
				}
				Console.WriteLine($"\nSivukulut yhteensä: -{yhteensa} e");
			} else
			{
				Console.WriteLine("Ei sivukuluja.");
			}
		}
	}
}