using System;


namespace AprendendoCSharpe.Loops
{
    class LoopDoWhile
    {
        static void Main()
        {
            string senha = "123";
            string senhaDigitada;
            int numeroTentativas = 0;

            do
            {
                Console.WriteLine("Digite a senha: ");
                senhaDigitada = Console.ReadLine();

                if (senhaDigitada != senha)
                {
                    Console.Clear();
                    Console.WriteLine($"A senha {senhaDigitada} está incorreta! Por favor, difite novamente.");
                }
                numeroTentativas++;
                Console.WriteLine($"Número de tentativas: {numeroTentativas}");

                if(numeroTentativas == 3)
                {
                    Console.WriteLine("Ultima tentativa! Mais uma tentativa e sua conta será bloqueada.");
                }

                if(numeroTentativas > 3)
                {
                    Console.WriteLine("Senha bloqueada!");
                    Environment.Exit(0);
                    Console.ReadLine();
                }

            } while (senha != senhaDigitada);
            Console.Clear();

            Console.WriteLine("Senha correta! Programa encerrado.");
            Console.ReadLine();
        }
    }
}
;