using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_OrientacaoObjeto
{
    class Programa
    {
        static void Main(string[] args)
        {
            Titular t = new Titular();
            Veiculo v = new Veiculo();
            int escolha;
            do
            {
                Console.WriteLine("############## ESCOLHA A AÇÃO ##############  \n\n");
                Console.WriteLine("1)- Informe os dados do Proprietário e Automóvel: ");
                Console.WriteLine("2)- Verificar os  dados cadastrados do Automóvel: ");
                Console.WriteLine("3)- Finalizar o Programa : ");
                Console.Write("Informe qual das operações deseja realizar: ");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 2)
                {
                    Console.WriteLine("Nome:");
                    Console.WriteLine("CPF:");
                    Console.WriteLine("Data de nascimento:");
                    Console.WriteLine("Endereço:");
                    Console.WriteLine("Data de compra do veículo:");
                }
                else
                {
                    Console.WriteLine(escolha); 
                }
                switch (escolha)
                {  // apenas as funções puxando a variavel 
                    case 1:
                        LerDados(t, v);
                        escolha = 0;
                        break;

                    case 2:
                        ImprimirDados(t, v);
                        escolha = 0;
                        break;
                }
            } while (escolha != 3);
            
        }

        public static void LerDados(Titular t, Veiculo v)
        {
            t.LerDados();
            v.LerDados();

        }

        public static void ImprimirDados(Titular t, Veiculo v)
        {
            
            Console.WriteLine(t.ToString());
            Console.WriteLine(v.ToString());
            Console.WriteLine("\n\nPrecione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}


/*
Elabore um programa que:

Cadastre um veiculo (Renavan, chassis, placa, marca, modelo
cor, ano)

também cadastre o proprietário Pessoa fisica do veículo
(nome, endereço, data de nascimento, da compra)


 o usuários poderá escolher em um menu principal se deseja:
1) informar todos os dados
2) imprimir os dados que possui
3) finalizar o programa */