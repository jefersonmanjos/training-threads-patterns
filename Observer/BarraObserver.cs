using System;

namespace Observer
{
	internal class BarraObserver : DadosObserver
	{
		public BarraObserver(DadosSubject dados) : base(dados)
		{
		}

		public override void Update()
		{
			String barraA = "", barraB = "", barraC = "";

			for (int i = 0; i < dados.getState().valorA; i++)
			{
				barraA += '=';
			}

			for (int i = 0; i < dados.getState().valorB; i++)
			{
				barraB += '=';
			}

			for (int i = 0; i < dados.getState().valorC; i++)
			{
				barraC += '=';
			}

			Console.WriteLine("Barras:\n Valor A: " + barraA + "\nValor B: "
					+ barraB + "\nValor C: " + barraC);
		}
	}
}
