using Newtonsoft.Json;
using System;

namespace Palkanlaskenta
{
	[JsonObject]
	public class Tyontekija
	{
		public string Nimi { get; set; }

		//constructor
		public Tyontekija(string nimi) {
			this.Nimi = nimi;
		}
	}
}