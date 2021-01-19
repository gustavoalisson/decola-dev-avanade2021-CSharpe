using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpe.Valores_Do_Teclado
{
    class ValorTeclado
    {
        public static void Main(string [] args)
        {
            int valor1, valor2, soma;
            string nome, sobrenome;

            Console.WriteLine("Informe o seu primeiro nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o seu sobrenome");
            sobrenome = Console.ReadLine();

            Console.WriteLine($"Nome digitado: {nome} {sobrenome}");

            Console.WriteLine("Por favor, digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            soma = valor1 + valor2;

            Console.WriteLine($"Olá {nome} {sobrenome} a soma dos dois valores é igual a {soma}");



        }
    }
}
