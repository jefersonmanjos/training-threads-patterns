using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
	internal class Host : IHost
	{
		private readonly IList<IPerson> people;
		public Host()
		{
			people = new List<IPerson>();
		}
		public void Add(IPerson person)
		{
			people.Add(person);
		}

		public int Count()
		{
			return people.Count;
		}
	}
}
