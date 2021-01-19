using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpe.Condiciocal_IF
{
    class CondicionalIF
    {
        static void Main(string [] args)
        {
            int nota = 0;
            

            Console.WriteLine("Digite a sua nota entre 10 e 100");
            nota = int.Parse(Console.ReadLine());

            if(nota >= 70)
            {
                Console.WriteLine("Aluno aprovado.");
            }
           
        }
    }
}
