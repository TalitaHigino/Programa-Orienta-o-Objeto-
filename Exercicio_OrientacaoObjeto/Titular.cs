using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OrientacaoObjeto
{
    public class Titular
    {
        public string nome { get; set; }        
        public float CPF { get; set; }
        public double data_nascimento { get; set; }
        public string endereco { get; set; }        
        public double data_compra { get; set; }

        public void LerDados()
        {
            Console.WriteLine("Informe os dados da pessoa");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Cpf : ");
            CPF = float.Parse(Console.ReadLine());            
            Console.Write("Data de Nasciemnto: ");
            data_nascimento = double.Parse(Console.ReadLine());
            Console.Write("Endereço: \n");
            endereco = Console.ReadLine();
            Console.Write("Data de compra do veículo: ");
            data_compra =double.Parse(Console.ReadLine());        
        }

        public override string ToString()
        {
            if (escolha == 2)
            {
                Console.WriteLine("Nome:");
                Console.WriteLine("CPF:");
                Console.WriteLine("Data de nascimento:");
                Console.WriteLine("Endereço:");
                Console.WriteLine("Data de compra do veículo:");
            }
            return ("CPF: " + CPF + "\nNome: " + nome + "\nEndereço: \n" + endereco.ToString() + "\nData de nascimento: " + data_nascimento + "\n Data da compra do veiculo: " + data_compra);
            
        }
    }
}

// nome ,cpf,  endereço, data de nascimento e de compra do veiculo 
