using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpe.Formatacao_De_Saida
{
    class Class
    {
        static void Main(string [] args)
        {
            int n1, n2, n3;
            n1 = 10; n2 = 20; n3 = 40;

            Console.WriteLine(n1 + ", " + n2 + ", " + n3);

            Console.WriteLine("n1 = {0}, n2 = {1}, n3 = {2}", n1, n2, n3);

            Console.WriteLine($"n1 = {n1}, n2 = {n2}, n3 = {n3}");

        }

        void OutroExemplo()
        {
            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "coxinha";

            valorVenda = valorCompra + (valorCompra + lucro);

            Console.WriteLine("Produto........{0,15}", produto); //obs: O espaçamento vem do 15
            Console.WriteLine("Val.Compra.....{0,15:c},", valorCompra); // formato de moeda
            Console.WriteLine("Lucro..........{0,15:p}", lucro); // formato porcentagem
            Console.WriteLine("Val.Venda......{0,15:p}", valorVenda);
        }
    }
}
