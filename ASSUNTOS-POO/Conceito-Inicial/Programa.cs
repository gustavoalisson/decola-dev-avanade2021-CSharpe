using System;


namespace AprendendoCSharpe.ASSUNTOS_POO.Conceito_Inicial
{
    class Programa
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Por favor, digite o seu nome:");
            nome = Console.ReadLine();


            // criando a instância da Conta
            // É possível criar várias instâncias dessa classe
            Conta contaA = new Conta();

            contaA.Saldo = 5000;
            contaA.Limite = 1000;
            contaA.Numero = 1010;

            Console.WriteLine($"Olá {nome}, o seu saldo é de {contaA.Saldo}");
            Console.WriteLine($"O seu limite para saque é de {contaA.Limite}");
            Console.WriteLine($"O número da sua conta é {contaA.Numero}");


        }
    }
}
