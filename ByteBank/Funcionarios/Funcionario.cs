using System;
namespace ByteBank.Funcionarios
{
	public class Funcionario
	{
		// 0 - funcionario; 1 - diretor; 2 - designer; 3 - Gerente Conta Corrente; 4 - Coordenador
		//private int _tipo;

		public string Nome { get; set; }
		public string CPF { get; set; }
		public double Salario { get; set; }

		public Funcionario()
		{
			//this._tipo = tipo;
		}

		public double GetBonificacao()
		{
			return Salario * 0.10;
		}
	}
}
