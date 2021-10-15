using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta
{
	class ListaaTyontekijat : MenuToiminto
	{
		public override void Suorita()
		{
			Console.Clear();

			List<Tyontekija> tyontekijat = HaeTyontekijat();

			if (tyontekijat.Count > 0)
			{
				// lista ilman sivukuluja
				foreach (Tyontekija t in tyontekijat)
				{
					t.ListaaTiedot();
				}

				// sivukulujen katsominen
				// tarkistetaan onko 0, kysyy uudestaan jos tyhjä
				Console.WriteLine("\nKatso tarkemmat tiedot (nimi; 0 palaa päävalikkoon): ");
				string input = "";
				while (input == "")
				{
					input = Console.ReadLine();
					if (input == "0")
					{
						return;
					}
				}

				// näytetään yhden työntekijän tiedot + sivukulut
				if (input != "0")
				{
					Console.Clear();

					int tyontekijaIndex = tyontekijat.FindIndex(x => x.Nimi == input);

					if (tyontekijaIndex == -1)
					{
						Console.WriteLine("Nimeä ei löytynyt.");
					}
					else
					{
						tyontekijat[tyontekijaIndex].TulostaPalkkaTiedot();
					}

					// Tänne muokkaus?
				}

			}
			else
			{
				Console.WriteLine("Listassa ei ole työntekijöitä.");
			}
			Console.ReadLine();
		}
	}
}
