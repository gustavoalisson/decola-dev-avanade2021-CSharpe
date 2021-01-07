using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpe.Escopo_Variaveis
{
    class Escopo
    {
        //Variavel global 

        int numeroGlobal = 100;
        static string nome = "Alisson";
         static void Main(string [] args)
        {
            int numero = 10;
            // utilizando a variavel global nome (static)
            Console.WriteLine(nome);


        }

        void teste()
        {
            //Isso irá gerar um erro porque a variavel numero não tem visibilidade nesse metodo
            // >>>> Console.WriteLine(numero);
            
            // utilizando a variavel globalr
            Console.WriteLine(numeroGlobal);
        }
    }
}
