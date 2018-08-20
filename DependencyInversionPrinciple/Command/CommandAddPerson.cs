using MediatR;

namespace DependencyInversionPrinciple.Command
{
	public class CommandAddPerson : IRequest<string>
	{
		public string Name { get; }
		public CommandAddPerson(string name)
		{
			Name = name;
		}
	}
}
