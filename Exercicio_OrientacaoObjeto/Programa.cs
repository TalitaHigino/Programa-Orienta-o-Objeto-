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
            Endereço endereço = new Endereço();
            int escolha;
            do
            {
                Console.WriteLine("############## ESCOLHA A AÇÃO ##############  \n\n");
                Console.WriteLine("1)- Informe os dados do Proprietário e do Automóvel: ");
                Console.WriteLine("2)- Verificar os  dados cadastrados: ");
                Console.WriteLine("3)- Finalizar o Programa : ");
                Console.Write("Informe qual das operações deseja realizar: ");

                escolha = int.Parse(Console.ReadLine());

                

                switch (escolha)
                {  // apenas as funções puxando a variavel 
                    case 1:
                        Console.WriteLine("Informe os dados da pessoais: ");
                        Console.Write("Nome Completo: ");
                        t.nome = Console.ReadLine();
                        Console.Write("CPF : ");
                        t.CPF = Console.ReadLine();
                        Console.Write("Data de Nasciemnto: ");
                        t.data_nascimento = (Console.ReadLine());
                        Console.Write("Endereço: ");
                        t.endereco = Console.ReadLine();
                        Console.Write("Data de compra do veículo: ");
                        t.data_compra = (Console.ReadLine());

                        Console.WriteLine("Informe os dados do veículo");
                        Console.Write("Renavan: ");
                        string Renavan = Console.ReadLine();
                        Console.Write("Chassis: ");
                        v.Chassis = Console.ReadLine();
                        Console.Write("Placa: ");
                        v.Placa = Console.ReadLine();
                        Console.Write("Marca: ");
                        v.Marca = Console.ReadLine();
                        Console.Write("Modelo: ");
                        v.Modelo = Console.ReadLine();
                        Console.Write("Cor: ");
                        v.Cor = Console.ReadLine();
                        Console.Write("Ano: ");
                        v.Ano = Console.ReadLine();
                        break;

                    case 2:
                        LerDados(t, v);
                        ImprimirDados(t, v);
                        escolha = 0;
                        break;
                    case 3:

                        break;

                }

            } while (escolha != 3);
            try
            {
                escolha = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite um Valor entre 1 e 3");

            }
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
            Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu...");
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