using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpe.Goto
{
    class comandoGoto
    {
        static void Main(string[] args)
        {
            char escolhaVeiculo;

            voltarInicio:
            Console.Clear();

            Console.WriteLine("Viagem: Recife/PE - São Pailo/SP");
            Console.WriteLine("Escolha um transporte: [a] - Avião | [b] - Ônibus | [c] - Carro");
            escolhaVeiculo = char.Parse(Console.ReadLine().ToLower());

            switch (escolhaVeiculo)
            {

                case 'a':
                    Console.WriteLine("Passagem de aviãO: R$853");
                    break;
                case 'b':
                    Console.WriteLine("Passagem de ônibus: R$500");
                    break;
                case 'c':
                    Console.WriteLine("Passagem de Carro: R$650");
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            char opcao;
            Console.WriteLine("Deseja verificar outro transporte ? [s/n]");
            opcao = char.Parse(Console.ReadLine().ToLower());

            if(opcao == 's')
            {
                goto voltarInicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Fim do programa.");
            }
            
        }
    }
}
