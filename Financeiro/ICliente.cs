namespace Financeiro
{
	public interface ICliente
	{
		string Name { get; set; }
		Endereco Endereco { get; set; }
		Telefone Telefone { get; set; }
	}
}
