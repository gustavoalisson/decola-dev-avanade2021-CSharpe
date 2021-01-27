using System;


namespace AprendendoCSharpe.ASSUNTOS_POO.Conceito_Inicial
{
    class Programa
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*** Conta Bancária *** ");

            // criando a instância da Conta
            // É possível criar várias instâncias dessa classe
            Conta contaA = new Conta();

            contaA.AdicionarLimite(1000);

            contaA.Deposita(450);
            contaA.Deposita(600);
            contaA.Deposita(2000);

            bool saque = contaA.Sacar(900);

            if (saque)
            {
                double saldo = contaA.ConsultaSaldoDisponivel();

                Console.WriteLine("Saldo atual: " + saldo);
                Console.WriteLine("Limite disponível: " + contaA.Limite);
            }

            


        }
    }
}
