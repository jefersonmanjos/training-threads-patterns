namespace MarioStatePattern
{
	internal class Mario
	{
		protected IMarioState estado;

		public Mario()
		{
			estado = new MarioPequeno();
		}

		public void PegarCogumelo()
		{
			estado = estado.PegarCogumelo();
		}

		public void PegarFlor()
		{
			estado = estado.PegarFlor();
		}

		public void PegarPena()
		{
			estado = estado.PegarPena();
		}

		public void LevarDano()
		{
			estado = estado.LevarDano();
		}
	}
}
