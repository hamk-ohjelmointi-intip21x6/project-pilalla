namespace Palkanlaskenta
{
	internal class Tyontekija
	{
		string Etunimi;
		string Sukunimi;

		//constructor
		public Tyontekija(string enimi, string snimi) {
			this.Etunimi = enimi;
			this.Sukunimi = snimi;
		}

		public string Nimi
		{
			get
			{
				return $"{this.Etunimi} {this.Sukunimi}";
			}
		}
	}
}