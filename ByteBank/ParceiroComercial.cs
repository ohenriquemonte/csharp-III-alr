using System;
using ByteBank.Sistemas;

namespace ByteBank
{
	public class ParceiroComercial : IAutenticavel
	{
		public string Senha { get; set; }

		public ParceiroComercial()
		{
		}

		public bool Autenticar(string senha)
		{
			return Senha == senha;
		}
	}
}
