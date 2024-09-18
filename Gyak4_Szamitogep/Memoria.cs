using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak4_Szamitogep
{
	internal class Memoria
	{
		private int meret; //GB
		private string tipus; //DDR3, DDR4

		public Memoria(int meret, string tipus)
		{
			this.Meret = meret;
			this.Tipus = tipus;
		}

		public int Meret { get => meret; set => meret = value; }
		public string Tipus { get => tipus; set => tipus = value; }

		public override string ToString()
		{
			return $"Memória: {this.meret} GB, Típus: {this.tipus}";
		}
	}
}
