using AdapterSampleDLL;
using System;

namespace AdapterSample
{
	public class Adaptador : ClasseExistente, IInterfaceCliente
	{
		public void Mostrar()
		{
			Console.WriteLine("Estou mostrando o exibir");
			Exibir();
		}
	}
}
