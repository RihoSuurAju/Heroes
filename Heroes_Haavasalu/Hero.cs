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
			return $"The hero {name} resides in {location}.";
		}
	}
}
