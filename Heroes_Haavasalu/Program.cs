using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Haavasalu
{
	class Program
	{
		private static List<Hero> heroes = new List<Hero>();
		private static void LoadHeroesFromFile(string Filename)
		{
			string[] data = File.ReadAllLines(Filename);
			for (int i = 0; i < data.Length; i++)
			{
				string[] name_loc = data[i].Split(new[] { " / " }, StringSplitOptions.None);
				if (data[0].EndsWith("*"))
				{
					heroes.Add(new Superhero(name_loc[0].Substring(0,name_loc[0].Length-1), name_loc[1]));
				}

				else
				{
					for (int j = 0; j < data.Length; j++)
					{
						heroes.Add(new Hero(name_loc[0], name_loc[1]));
					}
				}
			}
		}
		static void Main(string[] args)
		{
			Random r = new Random();

			Hero hero = new Hero("nunya", "Earth");
			Console.WriteLine("His name is " + hero.Name);
			Console.WriteLine("He resides within " + hero.Location);
			int people = hero.Rescue(r.Next(1,1000000));
			Console.WriteLine(hero + $"\nThis hero has saved {people} people.");
			Console.WriteLine();

			for (int i = 0; i < 3; i++)
			{
				Superhero superhero = new Superhero("Jimmy Neutron", "Retroville");
				people = superhero.Rescue(1000);
				Console.WriteLine(superhero + $"\nThis superhero has rescued {people} people.");
				Console.WriteLine();
			}
			Console.WriteLine();

			LoadHeroesFromFile("heroes.txt");
			foreach (Hero heroo in heroes)
			{
				Console.WriteLine(heroo);
				Console.WriteLine($"This hero has saved {heroo.Rescue(1000)} people.");
			}
			Console.ReadLine();
		}
	}
}