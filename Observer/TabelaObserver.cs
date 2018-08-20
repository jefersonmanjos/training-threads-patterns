using System;

namespace Observer
{
	internal class TabelaObserver : DadosObserver
	{

		public TabelaObserver(DadosSubject dados) : base(dados)
		{

		}
		public override void Update()
		{
			Console.WriteLine("Tabela:\nValor A: " + dados.getState().valorA
					+ "\nValor B: " + dados.getState().valorB + "\nValor C: "
					+ dados.getState().valorC);
		}

	}
}
