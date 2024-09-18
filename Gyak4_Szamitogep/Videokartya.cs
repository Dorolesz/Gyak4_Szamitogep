using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak4_Szamitogep
{
	internal class Videokartya
	{
		private string gyarto;
		private int vram; //GB

		public Videokartya(string gyarto, int vram)
		{
			this.Gyarto = gyarto;
			this.Vram = vram;
		}

		public string Gyarto { get => gyarto; set => gyarto = value; }
		public int Vram { get => vram; set => vram = value; }

		public override string ToString()
		{
			return $"Videokártya: {this.gyarto}, VRAM: {this.vram} GB";
		}
	}
}
