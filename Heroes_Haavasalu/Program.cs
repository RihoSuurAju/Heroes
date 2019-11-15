using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Haavasalu
{
	class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();

			Hero hero = new Hero("nunya", "Earth");
			Console.WriteLine("His name is " + hero.Name);
			Console.WriteLine("He resides within " + hero.Location);
			int rescued = hero.Rescue(r.Next(1,1000000));
			Console.WriteLine(hero + $"\nThis hero has saved {rescued} people.");
			Console.WriteLine();

			Superhero superhero = new Superhero("Jimmy Neutron", "Retroville");
			int superRescued = superhero.Rescue(100);
			Console.WriteLine(superhero + $"\nThis superhero has rescued {superRescued} people.");
			Console.ReadLine();
		}
	}
}