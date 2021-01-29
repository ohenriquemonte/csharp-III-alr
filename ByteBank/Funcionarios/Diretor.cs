using System;
namespace ByteBank.Funcionarios
{
	public class Diretor : Funcionario
	{
		public Diretor()
		{ }

		public override double GetBonificacao()
		{
			return Salario + base.GetBonificacao();
		}
	}
}
