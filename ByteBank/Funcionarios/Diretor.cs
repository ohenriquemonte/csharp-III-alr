using System;
namespace ByteBank.Funcionarios
{
	public class Diretor : Funcionario
	{
		public Diretor(string cpf) : base(cpf, 5000)
		{
			//Console.WriteLine("Criando Diretor");
		}

		public override void AumentarSalario()
		{
			Salario *= 1.15;
		}	

		public override double GetBonificacao()
		{
			return Salario * 0.5;
		}
	}
}
