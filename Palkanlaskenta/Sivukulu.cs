using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta
{
	class Sivukulu
	{
		public string Nimi { get; set; }
		public double Maara { get; set; }

		public Sivukulu(string nimi, double maara)
		{
			Nimi = nimi;
			Maara = maara;
		}
	}
}
