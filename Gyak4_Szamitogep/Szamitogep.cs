using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak4_Szamitogep
{
	internal class Szamitogep
	{
		private string nev;
		private Processzor processzor;
		private Memoria memoria;
		private Videokartya videokartya;

		public Szamitogep(string nev, Processzor processzor, Memoria memoria, Videokartya videokartya) 
		{
			this.nev = nev;
			this.processzor = processzor;
			this.memoria = memoria;
			this.videokartya = videokartya;
		}

		public string Nev { get => nev; set => nev = value; }
		internal Processzor Processzor { get => processzor; set => processzor = value; }
		internal Memoria Memoria { get => memoria; set => memoria = value; }
		internal Videokartya Videokartya { get => videokartya; set => videokartya = value; }

		public override string ToString()
		{
			return $"{nev}\n{Processzor}\n{Memoria}\n{Videokartya}";
		}
	}
}
