namespace MarioStatePattern
{
	internal class MarioFogo : IMarioState
	{
		
	public IMarioState PegarCogumelo()
		{
			System.Console.WriteLine("Mario ganhou 1000 pontos");
			return this;
		}

		
	public IMarioState PegarFlor()
		{
			System.Console.WriteLine("Mario ganhou 1000 pontos");
			return this;
		}

		
	public IMarioState PegarPena()
		{
			System.Console.WriteLine("Mario com capa");
			return new MarioCapa();
		}

		
	public IMarioState LevarDano()
		{
			System.Console.WriteLine("Mario grande");
			return new MarioGrande();
		}

	}
}
