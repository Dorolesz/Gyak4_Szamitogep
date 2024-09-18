using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak4_Szamitogep
{
	internal class Processzor
	{
		private double sebesseg;
		private string gyarto;
		public Processzor(double sebesseg, string gyarto)
		{
			this.sebesseg = sebesseg;
			this.gyarto = gyarto;
		}

		public double Sebesseg { get => sebesseg; set => sebesseg = value; }
		public string Gyarto { get => gyarto; set => gyarto = value; }

		public override string ToString()
		{
			return $"Processzor: {this.gyarto}, Sebesség: {this.sebesseg} GHz";
		}
	}
}
