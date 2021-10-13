using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta
{
	public class LisaaUusiTyontekija : MenuToiminto
	{
		public override void Suorita()
		{
			Console.Clear();

			List<Tyontekija> tyontekijat = haeTyontekijat();

			Console.WriteLine("Etunimi: ");
			string enimi = Console.ReadLine();

			Console.WriteLine("Sukunimi: ");
			string snimi = Console.ReadLine();

			Console.WriteLine("Tuntimäärä (per vko): ");
			string tunnit = Console.ReadLine();

			Tyontekija uusi = new Tyontekija(enimi + " " + snimi + " " + tunnit + " tuntia viikossa");

			tyontekijat.Add(uusi);
			Save.WriteToJsonFile("tyontekijat.json", tyontekijat);
		}
	}
}
