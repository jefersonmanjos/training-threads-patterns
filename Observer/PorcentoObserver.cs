using System;

namespace Observer
{
	internal class PorcentoObserver : DadosObserver
	{
		public PorcentoObserver(DadosSubject dados) : base(dados)
		{
		}

		public override void Update()
		{
			decimal somaDosValores = dados.getState().valorA + dados.getState().valorB
					+ dados.getState().valorC;
			decimal porcentagemA = dados.getState().valorA / somaDosValores;
			decimal porcentagemB = dados.getState().valorB / somaDosValores;
			decimal porcentagemC = dados.getState().valorC / somaDosValores;
			Console.WriteLine("Porcentagem:\nValor A: " + porcentagemA + "%\nValor B: " + porcentagemB + "%\nValor C: " + porcentagemC + "%");
		}
	}
}
