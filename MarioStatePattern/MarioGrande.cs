namespace MarioStatePattern
{
	internal class MarioGrande : IMarioState
	{
		
	public IMarioState PegarCogumelo()
		{
			System.Console.WriteLine("Mario ganhou 1000 pontos");
			return this;
		}

		
	public IMarioState PegarFlor()
		{
			System.Console.WriteLine("Mario com fogo");
			return new MarioFogo();
		}

		
	public IMarioState PegarPena()
		{
			System.Console.WriteLine("Mario com capa");
			return new MarioCapa();
		}

		
	public IMarioState LevarDano()
		{
			System.Console.WriteLine("Mario pequeno");
			return new MarioPequeno();
		}
	}
}
