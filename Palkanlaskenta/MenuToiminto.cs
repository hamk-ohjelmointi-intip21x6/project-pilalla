using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkanlaskenta
{
	public abstract class MenuToiminto
	{
		public abstract void Suorita();
		public List<Tyontekija> HaeTyontekijat()
		{
			List<Tyontekija> tyontekijat = new List<Tyontekija>();

			if (Save.ReadFromJsonFile<List<Tyontekija>>("tyontekijat.json") != null)
			{
				tyontekijat = Save.ReadFromJsonFile<List<Tyontekija>>("tyontekijat.json");
			}

			return tyontekijat;
		}
	}
}
