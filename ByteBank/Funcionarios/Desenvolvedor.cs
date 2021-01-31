using System;
namespace ByteBank.Funcionarios
{
	public class Desenvolvedor : Funcionario
	{
		public Desenvolvedor(string cpf) : base(cpf, 3000)
		{
		}

		public override void AumentarSalario()
		{
			Salario *= 0.15;
		}

		public override double GetBonificacao()
		{
			return Salario * 0.1;
		}
	}
}
