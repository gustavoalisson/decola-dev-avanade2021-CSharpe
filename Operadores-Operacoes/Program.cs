using System;

namespace AprendendoCSharpe.Operadores_Operacoes
{
    class Program
    {
        static void Main(string []args)
        {
            int resultado = (10 + 5) * 5;
            int cont = 1;

            // incremento
            cont++;

            Console.WriteLine(resultado);

            // operador relacional
            // == != < > <= >=
            bool verifica = 10 < 5;

            Console.WriteLine(verifica);

            //Operadores lógicos
            // & - E
            // || - OU
            bool res = (5 > 8) | (10 < 5); // True
            bool res2 = (5 > 8) & (10 < 5); // False
        }
    }
}
