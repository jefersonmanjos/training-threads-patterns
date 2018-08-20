namespace DependencyInversionPrinciple
{
	public interface IHost
	{
		void Add(IPerson person);
		int Count();
	}
}
