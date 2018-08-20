namespace DependencyInversionPrinciple
{
	internal class Person : IPerson
	{
		public string Name { get; }
		public Person(string name)
		{
			Name = name;
		}
	}
}
