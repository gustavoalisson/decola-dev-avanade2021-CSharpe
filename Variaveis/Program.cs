using System;


namespace AprendendoCSharpe
{
     class Program
    {
        static void Main (string [] args)
        {
            //declaração de uma variável
            //inicializando uma variável
            byte n1 = 10;
            int idade = 23;
            char letra = 'a';
            float valor2 = 10.5f;
            string nome = "Alisson Gustavo";
            int num1 = 0, num2 = 0, num3 = 0;
            
            // não é especificado o tipo da variável
            // não é necessário determinar o tipo na declaração
            var aux = 10;

            //Lendo uma variável
            Console.WriteLine(nome);

            //Concatenação
            Console.WriteLine("Meu nome é " + nome);
            // Concatenando usando a interpolação
            Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");

            

    }
    }
}
