using System;
using System.Collections.Generic;
using System.Text;

namespace MarioStatePattern
{
	class MarioCapa : IMarioState
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
			System.Console.WriteLine("Mario ganhou 1000 pontos");
			return this;
		}

		
	public IMarioState LevarDano()
		{
			System.Console.WriteLine("Mario grande");
			return new MarioGrande();
		}
	}
}
