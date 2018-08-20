namespace MarioStatePattern
{
	internal interface IMarioState
	{
		IMarioState PegarCogumelo();
		IMarioState PegarFlor();
		IMarioState PegarPena();
		IMarioState LevarDano();
	}
}
