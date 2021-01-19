using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpe.Condicional_IF_ELSE
{
   public class IfElse
    {
        static void Main(string[] args)
        {
            int nota1 = 0,nota2 = 0,nota3 = 0,nota4 = 0;
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

            if (resultado >= 70)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine($"Nota: {resultado}");
            }
            else if(resultado >= 40 & resultado <= 69 )
            {
                Console.WriteLine("Aluno Recuperação");
                Console.WriteLine($"Nota: {resultado}");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine($"Nota: {resultado}");
            }
           
            Console.ReadLine();

        }
    }
}
