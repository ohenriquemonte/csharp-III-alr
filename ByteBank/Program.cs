using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();


			Funcionario carlos = new Funcionario();

			carlos.Nome = "Carlos";
			carlos.CPF = "123.123.123-12";
			carlos.Salario = 2000;

			Diretor roberta = new Diretor();
			roberta.Nome = "Roberta";
			roberta.CPF = "232.321.123-92";
			roberta.Salario = 5000;

			gerenciador.Registrar(carlos);
			gerenciador.Registrar(roberta);

			Console.WriteLine("Total de bonificações: {0}", gerenciador.getTotalBonificacao());

			Console.ReadLine();
		}
	}
}
