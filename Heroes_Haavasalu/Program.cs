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
			int people = hero.Rescue(r.Next(1,1000000));
			Console.WriteLine(hero + $"\nThis hero has saved {people} people.");
			Console.WriteLine();

			for (int i = 0; i < 10; i++)
			{
				Superhero superhero = new Superhero("Jimmy Neutron", "Retroville");
				people = hero.Rescue(1000);
				Console.WriteLine(superhero + $"\nThis superhero has rescued {people} people.");
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}