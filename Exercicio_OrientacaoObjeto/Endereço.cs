using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OrientacaoObjeto
{
     public class Endereço
    {
		
		public string Logradouro { get; set; }
		public int Numero { get; set; }
		public string Localidade { get; set; }


		public void LerDados()
		{
			
			Console.Write("	Logradouro: ");
			Logradouro = Console.ReadLine();
			Console.Write("	Número: ");
			Numero = int.Parse(Console.ReadLine());
			Console.Write("	Localidade: ");
			Localidade = Console.ReadLine();
		}
		/*public override string ToString()
		{
			return ("	Logradouro: " + Logradouro + "\n	Número: " + Numero + "\n	Localidade: " + Localidade);
		}*/
	}
}

