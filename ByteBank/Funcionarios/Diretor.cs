using System;
namespace ByteBank.Funcionarios
{
	public class Diretor
	{
		public Diretor()
		{
		}

		public string Nome { get; set; }
		public string CPF { get; set; }
		public double Salario { get; set; }

		public double GetBonificacao()
		{
			return Salario;
		}
	}
}
