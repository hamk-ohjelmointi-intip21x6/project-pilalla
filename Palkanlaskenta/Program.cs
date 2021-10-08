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
			tunnus.KäyttäjäTunnus = "Matti Koivu";
			tunnus.Salasana = 1234;
			List<Kirjautuminen> käyttäjäTunnus = new List<Kirjautuminen>();
			käyttäjäTunnus.Add(tunnus);

			// Kirjoitetaan tekstitiedostoon käyttäjätunnuslista (jos tekstitiedostoa ei ole, luodaan uusi)
			using (StreamWriter file = new StreamWriter("KirjautumisTunnus.txt"))
            {
				var käyttäjäTunnusTekstiTiedostoon = $"{käyttäjäTunnus[0].KäyttäjäTunnus};{käyttäjäTunnus[0].Salasana}";
				file.WriteLine(käyttäjäTunnusTekstiTiedostoon);
            }

			// Luetaan tekstitiedostoa
			string line;
			StreamReader sr = new StreamReader("KirjautumisTunnus.txt");
			line = sr.ReadLine();
			// Ja tulostetaan se ihan vain malliksi että muistaa mikä on tunnus ja salasana
			Console.WriteLine(line);

			// Kysytään käyttäjätunnus ja salasana
			Console.WriteLine("\nSyötä Käyttäjätunnus");
			var eka = Console.ReadLine();
			Console.WriteLine("\nSyötä Salasana");
			var toka = Console.ReadLine();
			// Yhdistetään käyttäjätunnus ja salasana
			var yhteen = eka +";"+ toka;

			List<Tyontekija> tyontekijat = new List<Tyontekija>();

			// Jos käyttäjätunnus ja salasana ovat oikein pääsee muokkaamaan työntekijälistaa
			if (yhteen.ToLower() == line.ToLower())
            {
				bool quit = false;
				while (quit == false)
				{
					Console.Clear();
					Console.WriteLine("0. lopeta\n1. Työntekijälista\n2. Lisää työntekijä");

					switch (Console.ReadLine())
					{
						case "0":
							quit = true;
							break;

					case "1": //Tulosta työntekijälista

						MenuToiminto listaa = new ListaaTyontekijat();
						listaa.Suorita();
						Console.ReadLine();

						break;

					case "2": //Lisää työntekijä

						MenuToiminto lisaaTyontekija = new LisaaUusiTyontekija();
						lisaaTyontekija.Suorita();

							break;

					case "3":

						MenuToiminto poistaTyontekija = new PoistaTyontekija();
						poistaTyontekija.Suorita();

						break;

						default:
							break;
					}
				}
			}
			else
            {
				Console.WriteLine("Väärä käyttäjätunnus tai salasana");
            }
		}
	}
}
