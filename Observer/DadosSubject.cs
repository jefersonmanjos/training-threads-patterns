using System.Collections.Generic;

namespace Observer
{
	internal class DadosSubject
	{

		protected List<DadosObserver> observers;
		protected Dados dados;

		public DadosSubject()
		{
			observers = new List<DadosObserver>();
		}

		public void attach(DadosObserver observer)
		{
			observers.Add(observer);
		}

		public void detach(int indice)
		{
			observers.RemoveAt(indice);
		}

		public void setState(Dados dados)
		{
			this.dados = dados;
			notifyObservers();
		}

		private void notifyObservers()
		{
			foreach (DadosObserver observer in observers)
			{
				observer.Update();
			}
		}

		public Dados getState()
		{
			return dados;
		}

	}
}
