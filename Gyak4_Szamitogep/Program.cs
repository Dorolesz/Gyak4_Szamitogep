using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak4_Szamitogep
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Szamitogep> szamitogepek = new List<Szamitogep>
			{
				new Szamitogep("Gamer PC", new Processzor(3.8, "Intel"), new Memoria(16, "DDR4"), new Videokartya("NVIDIA", 8)),
				new Szamitogep("Workstation", new Processzor(3.6, "AMD"), new Memoria(32, "DDR4"), new Videokartya("AMD", 16)),
				new Szamitogep("Office PC", new Processzor(2.5, "Intel"), new Memoria(8, "DDR3"), new Videokartya("Intel", 2)),
			};
			OsszesPC(szamitogepek);
            Console.WriteLine("\nNVIDIA videokártyák:");
			GPUGyartoAlapjan(szamitogepek, "NVIDIA");

            Console.ReadKey();
		}

		public static void OsszesPC(List<Szamitogep> szamitogepek)
		{
            foreach (var gep in szamitogepek)
            {
                Console.WriteLine(gep);
                Console.WriteLine();
			}
		}

		public static void GPUGyartoAlapjan(List<Szamitogep> szamitogepek, string gyarto)
		{
			var filtered = szamitogepek.Where(g => g.Videokartya.Gyarto == gyarto);
			foreach (var gep in filtered)
			{
				Console.WriteLine(gep);
				Console.WriteLine();
			}
		}
		//Itt használtam AI-t (csak a Program.cs-ben)
	}
}
