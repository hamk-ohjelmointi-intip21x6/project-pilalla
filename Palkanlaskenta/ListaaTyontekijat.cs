using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta
{
	public class ListaaTyontekijat : MenuToiminto
	{
		public override void Suorita()
		{
			Console.Clear();

			List<Tyontekija> tyontekijat = new List<Tyontekija>();

			if (Save.ReadFromJsonFile<List<Tyontekija>>("tyontekijat.json") != null)
			{
				tyontekijat = Save.ReadFromJsonFile<List<Tyontekija>>("tyontekijat.json");
			}

			if (tyontekijat.Count > 0)
			{
				foreach (Tyontekija t in tyontekijat)
				{
					Console.WriteLine(t.Nimi);
				}
			}
			else
			{
				Console.WriteLine("Listassa ei ole työntekijöitä.");
			}

			// tähän työntekijöiden/listan muokkaus?

			Console.ReadLine();
		}
	}
}
