using System;
using System.Collections.Generic;
using System.IO;
// testikommentti
namespace Palkanlaskenta
{
	class Program
	{
		static void Main(string[] args)
		{
			Kirjautuminen tunnus = new Kirjautuminen();
			tunnus.EtuNimi = "Matti";
			tunnus.SukuNimi = "Koivu";
			List<Kirjautuminen> käyttäjäTunnus = new List<Kirjautuminen>();
			käyttäjäTunnus.Add(tunnus);

			using (StreamWriter file = new StreamWriter("KirjautumisTunnus.txt"))
            {
				var käyttäjäTunnusTekstiTiedostoon = $"{käyttäjäTunnus[0].EtuNimi};{käyttäjäTunnus[0].SukuNimi}";
				file.WriteLine(käyttäjäTunnusTekstiTiedostoon);
            }
			Console.WriteLine($"{käyttäjäTunnus[0].EtuNimi} {käyttäjäTunnus[0].SukuNimi}");

			List<Tyontekija> tyontekijat = new List<Tyontekija>();

			bool quit = false;
			while (quit == false)
			{
				//Console.Clear();
				Console.WriteLine("0. lopeta\n1. Työntekijälista\n2. Lisää työntekijä");

				switch (Console.ReadLine())
				{
					case "0":
						quit = true;
						break;

					case "1":
						Console.Clear();

						if (tyontekijat.Count > 0)
						{
							foreach (Tyontekija t in tyontekijat)
							{
								Console.WriteLine(t.Nimi);
							}
						} else
						{
							
							Console.WriteLine("Listassa ei ole työntekijöitä.");
							
						}
						Console.ReadLine();

						break;

					case "2":
						Console.Clear();

						Console.WriteLine("Etunimi: ");
						string enimi = Console.ReadLine();

						Console.WriteLine("Sukunimi: ");
						string snimi = Console.ReadLine();

						Tyontekija uusi = new Tyontekija(enimi, snimi);
						tyontekijat.Add(uusi);
						break;

					case "3":
						Console.Clear();
						
						break;

					default:
						break;
				}
			}
			

		}
	}
}
