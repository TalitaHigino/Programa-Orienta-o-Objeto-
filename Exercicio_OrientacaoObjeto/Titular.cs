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
        public string CPF { get; set; }
        public string data_nascimento { get; set; }
        public string endereco { get; set; }
        public string data_compra { get; set; }

        public void LerDados()
        {
            Console.WriteLine("Informe os dados da pessoais: ");
            Console.Write("Nome Completo: ");
            string nome = Console.ReadLine();
            Console.Write("CPF : ");
            string CPF = Console.ReadLine();
            Console.Write("Data de Nasciemnto: ");
            string data_nascimento = (Console.ReadLine());
            Console.Write("Endereço: \n");
            string endereco = Console.ReadLine();            
            Console.Write("Data de compra do veículo: ");
            string data_compra = (Console.ReadLine());

        }

        /*public override string ToString()
        {
            
            
            return ("CPF: " + CPF + "\nNome: " + nome + "\nEndereço: \n" + endereco.ToString() + "\nData de nascimento: " + data_nascimento + "\n Data da compra do veiculo: " + data_compra);

        }*/
    }
}

// nome ,cpf,  endereço, data de nascimento e de compra do veiculo 
