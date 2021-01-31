using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

			//Funcionario carlos = new Funcionario("123.123.123-12", 2000);

			//carlos.Nome = "Carlos";
			////Console.WriteLine("Total Funcionarios após criação carlos: {0}", Funcionario.TotalDeFuncionarios);


			//Console.WriteLine("Salario do Carlos: {0}", carlos.Salario);
			//carlos.AumentarSalario();
			//Console.WriteLine("Novo Salario do Carlos: {0}", carlos.Salario);

			//Diretor roberta = new Diretor("232.321.123-92");
			//roberta.Nome = "Roberta";
			////Console.WriteLine("Total Funcionarios após criação roberta: {0}", Funcionario.TotalDeFuncionarios);

			//Console.WriteLine("Salario da Roberta: {0}", roberta.Salario);
			//roberta.AumentarSalario();
			//Console.WriteLine("Novo Roberta do Carlos: {0}", roberta.Salario);

			//gerenciador.Registrar(carlos);
			//gerenciador.Registrar(roberta);

			//Console.WriteLine("Total de bonificações: {0}", gerenciador.getTotalBonificacao());

			CalcularBonificacao();

			Console.ReadLine();
		}

		public static void CalcularBonificacao()
		{
			GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

			Designer pedro = new Designer("123.123.123-12");
			pedro.Nome = "Pedro";

			Diretor roberta = new Diretor("124.124.124-12");
			roberta.Nome = "Roberta";

			Auxiliar igor = new Auxiliar("125.125.125-12");
			igor.Nome = "Igor";

			GerenteDeConta camila = new GerenteDeConta("126.126.126-12");
			camila.Nome = "Camila";

			gerenciadorBonificacao.Registrar(pedro);
			gerenciadorBonificacao.Registrar(roberta);
			gerenciadorBonificacao.Registrar(igor);
			gerenciadorBonificacao.Registrar(camila);

			Console.WriteLine("Total de bonificações do mês: {0}", gerenciadorBonificacao.GetTotalBonificacao());
		}
	}
}
