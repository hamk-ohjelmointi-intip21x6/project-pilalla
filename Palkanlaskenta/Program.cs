using System;
using System.Collections.Generic;
// testikommentti
namespace Palkanlaskenta
{
	class Program
	{
		static void Main(string[] args)
		{
			// kirjautuminen tähän

			bool quit = false;
			while (quit == false)
			{

				Console.Clear();
				Console.WriteLine("0. lopeta\n1. Työntekijälista\n2. Lisää työntekijä\n3. Poista työntekijä");	
				
				switch (Console.ReadLine()) // työnantajan vaihtohdot
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
	}
}
