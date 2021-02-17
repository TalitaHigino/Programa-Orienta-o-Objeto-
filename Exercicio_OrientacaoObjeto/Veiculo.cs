using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OrientacaoObjeto
{
    public class Veiculo
    {
		public string Renavan { get; set; }

		public string Chassis { get; set; }

		public string Placa { get; set; }

		public string Marca { get; set; }

		public string Modelo { get; set; }

		public string Cor { get; set; }

		public string Ano { get; set; }

		public void LerDados()
		{
			Renavan = Renavan;
			Chassis = Chassis;
			Placa = Placa;
			Marca = Marca;
			Modelo = Modelo;
			Cor = Cor;
			Ano = Ano;
		}

		public override string ToString()
		{
			return ("Renavan: " + Renavan + "\nChassis: " + Chassis + 
				"\nPlaca: " + Placa + "\nMarca" + Marca + "\nModelo: " + Modelo + "\nCor: " 
				+ Cor + "\nAno: " + Ano);
		}
	}
}

// Renavan , chassis, placa, marca, modelo, cor e ano