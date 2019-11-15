using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Haavasalu
{
	class Hero
	{
		private string name;
		private string location;

		public Hero(string name, string location)
		{
			this.name = name;
			this.location = location;
		}

		public string Name { get => name; set => name = value; }
		public string Location { get => location; set => location = value; }

		public virtual int Rescue(int amountOfPeople)
		{
			return (int)Math.Round(amountOfPeople * 0.95);
		}

		public override string ToString()
		{
			return $"Hello! My name is {name}, and I come from {location}";
		}
	}

	class Superhero : Hero
	{
		double skill;

		public Superhero(string name, string location) : base(name, location)
		{
			Random r = new Random();
			skill = r.Next(1, 5);
		}

		public override string ToString()
		{
			return $"Superhero: {Name} \nLocation: {Location} \nSkill: {skill}";
		}

		public override int Rescue(int amountofPeople)
		{
			return (int)Math.Round(amountofPeople * 0.95 + skill);
		}

	}
}
