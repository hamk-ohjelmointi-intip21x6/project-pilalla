using System;
using System.Collections.Generic;

namespace Palkanlaskenta
{
	class PoistaTyontekija : MenuToiminto
	{
		public override void Suorita()
		{
			Console.Clear();

			List<Tyontekija> tyontekijat = HaeTyontekijat();

			if (tyontekijat.Count > 0)
			{
				foreach (Tyontekija t in tyontekijat)
				{
					t.ListaaTiedot();
				}
			}
			else
			{
				Console.WriteLine("Listassa ei ole työntekijöitä.");
			}

			Console.WriteLine("Poistettavan nimi (0 palaa päävalikkoon): ");

			string poistettavaNimi = Console.ReadLine();

			if (poistettavaNimi == "0")
			{
				return;
			}

			int poistettavaIndex = tyontekijat.FindIndex(x => x.Nimi == poistettavaNimi);

			if (poistettavaIndex == -1)
			{
				Console.WriteLine("Nimeä ei löytynyt.");
			}
			else
			{
				Console.WriteLine("Poistetaan " + tyontekijat[poistettavaIndex].Nimi + ". (y/n)");

				while (true)
				{
					string response = Console.ReadLine();
					if (response == "y")
					{
						tyontekijat.RemoveAt(poistettavaIndex);
						Console.WriteLine("Poistettu.");
						break;
					}
					else if (response == "n")
					{
						Console.WriteLine("Ei poistettu.");
						break;
					}
				}
				
				Save.WriteToJsonFile("tyontekijat.json", tyontekijat);

				Console.ReadLine();
			}

		}
	}
}