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
            nome = nome;
            CPF = CPF;  
            data_nascimento = data_nascimento;
            data_compra = data_compra;
            endereco = endereco;

        }

        public override string ToString()
        {
            
            
            return ("CPF: " + CPF + "\nNome: " + nome + "\nEndereço: \n" + 
                endereco.ToString() + "\nData de nascimento: " + data_nascimento + 
                "\n Data da compra do veiculo: " + data_compra);

        }
    }
}

// nome ,cpf,  endereço, data de nascimento e de compra do veiculo 
// por algum motivo não estou conseguindo usar o ToString em todos eles 