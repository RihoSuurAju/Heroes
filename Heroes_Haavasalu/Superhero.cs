using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Haavasalu
{
	class Superhero : Hero
	{
		private static Random r = new Random();
		private double skill;

		public Superhero(string name, string location) : base(name, location)
		{
			skill = r.Next(100, 501) / 100.0;
		}

		public double Skill { get => skill; }

		public override string ToString()
		{
			return base.ToString() + $"\nHe is extra skillful, and will save {skill}% more people.";
		}

		public override int Rescue(int amountOfPeople)
		{
			return (int)Math.Round(amountOfPeople * (0.95 + skill / 100.0));
		}

	}
}
