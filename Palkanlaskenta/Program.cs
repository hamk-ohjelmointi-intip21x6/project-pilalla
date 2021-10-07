using System;
using System.Collections.Generic;
// testikommentti
namespace Palkanlaskenta
{
	class Program
	{
		static void Main(string[] args)
		{

			bool quit = false;
			while (quit == false)
			{
				Console.Clear();
				Console.WriteLine("0. lopeta\n1. Työntekijälista\n2. Lisää työntekijä");

				// kirjautuminen tähän
				
				switch (Console.ReadLine()) // työnantajan vaihtohdot
				{
					case "0":
						quit = true;
						break;

					case "1": //Tulosta työntekijälista

						MenuToiminto listaa = new ListaaTyontekijat();
						listaa.Suorita();

						break;

					case "2": //Lisää työntekijä

						MenuToiminto lisaaUusi = new LisaaUusiTyontekija();
						lisaaUusi.Suorita();

						break;

					default:
						break;
				}
			}
			

		}
	}
}
