namespace Financeiro
{
	public class Cliente : ICliente
	{
		public Cliente(string name)
		{
			Name = name;
		}

		public string Name { get; set; }
		public Endereco Endereco { get; set; }
		public Telefone Telefone { get; set; }
	}

	public class ClienteRihappy : ICliente
	{
		private string name;

		public ClienteRihappy(string name)
		{
			Name = name;
		}

		public Endereco Endereco { get; set; }
		public Telefone Telefone { get; set; }
		public string Name { get => name.ToUpper(); set => name = value; }
	}
}
