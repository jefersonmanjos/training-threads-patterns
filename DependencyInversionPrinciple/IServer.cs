namespace DependencyInversionPrinciple
{
	public interface IServer
	{
		string DNS { get; }
		IHost Host { get; }
	}
}