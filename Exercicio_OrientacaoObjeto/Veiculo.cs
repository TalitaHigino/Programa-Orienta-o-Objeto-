using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OrientacaoObjeto
{
    public class Veiculo
    {
		public float Renavan { get; set; }

		public float Chassis { get; set; }

		public double  Placa { get; set; }

		public string Marca { get; set; }

		public string Modelo { get; set; }

		public string Cor { get; set; }

		public int Ano { get; set; }

		public void LerDados()
		{
			Console.WriteLine("Informe os dados do veículo");
			Console.Write("Renavan: ");
			string Renavan = Console.ReadLine();
			Console.Write("Chassis: ");
			Chassis = float.Parse(Console.ReadLine());
			Console.Write("Placa: ");
			Placa = double.Parse(Console.ReadLine());
			Console.Write("Marca: ");
			Marca = Console.ReadLine();
			Console.Write("Modelo: ");
			Modelo = Console.ReadLine();
			Console.Write("Cor: ");
			Cor = Console.ReadLine();
			Console.Write("Ano: ");
			Ano = int.Parse(Console.ReadLine());
		}

		/*public override string ToString()
		{
			return ("Renavan: " + Renavan + "\nChassis: " + Chassis + "\nPlaca: " + Placa + "\nMarca" + Marca + "\nModelo: " + Modelo + "\nCor: " + Cor + "\nAno: " + Ano);
		}*/
	}
}

// Renavan , chassis, placa, marca, modelo, cor e ano