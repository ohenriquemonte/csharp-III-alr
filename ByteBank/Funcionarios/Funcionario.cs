using System;
namespace ByteBank.Funcionarios
{
	public abstract class Funcionario
	{
		public static int TotalDeFuncionarios { get; private set; }

		public string Nome { get; set; }
		public string CPF { get; private set; }
		public double Salario { get; protected set; }

		public Funcionario(string cpf, double salario)
		{
			//Console.WriteLine("Criando Funcionário");

			CPF = cpf;
			Salario = salario;

			TotalDeFuncionarios++;
		}

		public abstract void AumentarSalario();
		//{
		//	//Salario = Salario + (Salario * 0.1); // implementacoes equivalentes
		//	//Salario = Salario + 1.1; // implementacoes equivalentes
		//	Salario *= 1.1; // implementacoes equivalentes
		//}

		public abstract double GetBonificacao();
		//{
		//	return Salario * 0.10;
		//}
	}
}
