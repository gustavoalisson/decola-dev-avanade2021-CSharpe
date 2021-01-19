using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpe.IF_Aninhado
{
    public class IFAninhado
    {
        static void Main(string[] args)
        {
            int nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;
            decimal resultado = 0;

            Console.WriteLine("Digite o valor da primeira nota: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da terceira nota: ");
            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da quarta nota: ");
            nota4 = int.Parse(Console.ReadLine());

            resultado = nota1 + nota2 + nota3 + nota4;

            if (resultado >= 60)
            {
                if (resultado >= 90)
                {
                    Console.WriteLine("Aprovado com excelência!");
                }
                else
                {
                    Console.WriteLine("Aprovado.");
                }
            }
            else
            {
                if (resultado >= 40)
                {
                    Console.WriteLine("Recuperação.");
                }
                else
                {
                    Console.WriteLine("Reprovado.");
                }
            }
           

        }
    }
}
