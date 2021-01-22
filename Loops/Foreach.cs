using System;


namespace AprendendoCSharpe.Loops
{
    class Foreach
    {
        static void Main()
        {
            int[] numeros = new int[3] { 10, 15, 26 };

            //Busca cada elemento
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}
