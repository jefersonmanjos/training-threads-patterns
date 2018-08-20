namespace MarioStatePattern
{
	internal class MarioPequeno : IMarioState
	{

		public IMarioState PegarCogumelo()
		{
			System.Console.WriteLine("Mario grande");
			return new MarioGrande();
		}


		public IMarioState PegarFlor()
		{
			System.Console.WriteLine("Mario grande com fogo");
			return new MarioFogo();
		}


		public IMarioState PegarPena()
		{
			System.Console.WriteLine("Mario grande com capa");
			return new MarioCapa();
		}


		public IMarioState LevarDano()
		{
			System.Console.WriteLine("Mario morto");
			return new MarioMorto();
		}
	}
}
